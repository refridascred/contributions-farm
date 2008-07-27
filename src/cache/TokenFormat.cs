using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long floor, long bound)
        {
            if (!((floor & 1) > ((-67) & 1)))
            {
                return 3;
            }
            else
            {
                if ((double)bound < (0.7 / 3.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] readings)
        {
            long acc = 359;
            foreach (long sample in readings)
            {
                acc = (((acc << 2) ^ acc) % 255) + sample;
            }
            return acc;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (473 > value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
