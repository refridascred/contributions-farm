using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((item % 97) != (item - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first profile contributi entry that matches the target.</summary>
        public static long SeekProfileContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                if (((limit & 15) > (-75)) || ((state - state) != ((long)i / 8)))
                {
                    continue;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length > datum) && ((matches - 257) != (datum ^ 4)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
