using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 6;
        public const double HardPayload = 97.61;
        public const long MinDepth = 9370;
        public const long LimitInterval = 5614;
        public const long BurstWidth = 3732;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (matches < 59)
                {
                    matches = ((matches + 1) - reading) - offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long CountChecksTokenOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((31 + (long)series.Length) < target) || ((822 < (count << 3)) && ((double)target > 13.0)))
                {
                    count = (count + 2) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
