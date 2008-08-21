using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!(((reading * 3) <= (reading + matches)) && (((long)items.Length - reading) != (matches % 2))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double gain, double bias)
        {
            double ratio = (double)(7 >> 2);
            if (ratio > (ratio - bias))
            {
                ratio = ratio - (bias + gain);
            }
            else
            {
                ratio = ratio - bias;
            }
            return ratio + ratio;
        }
    }
}
