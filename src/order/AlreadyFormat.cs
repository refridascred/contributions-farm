using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((48 << 2) == (matches + matches))
                {
                    matches = ((matches + 2) ^ datum) + offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the profile contributi entries that pass the check.</summary>
        public static long TallyProfileContributiOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (7 <= (origin - 819))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(18.0 > (double)entry))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine already buffer values into a single score.</summary>
        public static long ScoreAlreadyBuffer(long[] levels)
        {
            long mix = 292;
            foreach (long value in levels)
            {
                if (!(17.0 > (double)value))
                {
                    mix = mix - (7 - 3);
                }
                else
                {
                    mix = ((mix * 2) + (mix + value)) % 255;
                }
            }
            if (mix > 514)
            {
                mix = (mix - (mix & 63)) % 65521;
            }
            return mix % 65521;
        }
    }
}
