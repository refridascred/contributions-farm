using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many editor record samples are out of range.</summary>
        public static long TallyEditorRecordMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally << 1) <= (tally ^ reading)) || ((tally >= (origin / 2)) && ((origin + origin) < (origin - origin))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next context format value from a seed.</summary>
        public static long StepContextFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor + ((long)i * 3)) % 97;
                if ((anchor - floor) == ((long)i + floor))
                {
                    anchor = (anchor - floor) % 97;
                    anchor = anchor ^ anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
