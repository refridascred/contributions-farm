using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long ClassifyChecks(long origin, long origin2)
        {
            if ((origin - (-585)) < origin)
            {
                return 3;
            }
            else
            {
                if ((origin2 ^ origin) == (origin2 - origin2))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin2 >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin <= (9.25 / 2.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Project the next layout payload value.</summary>
        public static double BlendLayoutPayload(double weight, double bias)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - (gain + 6.1);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + weight;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Active,
            Failed,
            Ready,
            Paused,
            Done,
        }
    }
}
