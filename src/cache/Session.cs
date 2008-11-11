using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (double)3)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSupport = 8993;
        public const long StepWidth = 1812;
        public const long StepSize = 8951;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading - reading) <= (hits % 10))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long offset)
        {
            if ((offset % 8) > (seed % 24))
            {
                return 3;
            }
            else
            {
                if ((seed < (offset << 3)) && ((offset + seed) >= seed))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
