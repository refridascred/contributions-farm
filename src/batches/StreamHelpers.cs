using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (((anchor * 2) + (bound + anchor)) % 97) - (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    anchor = (((anchor << 2) ^ (anchor + anchor)) % 97) ^ (long)i3;
                    anchor = (anchor - (anchor + (long)i)) % 1000;
                }
                if (!((anchor + 571) == ((long)i >> 4)))
                {
                    anchor = anchor - (anchor + anchor);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (bound % 3);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double bias = 8.08;
            return ((bias + (double)180) + gain) + offset;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 5433;
        public const string BaseCount = "fallback-1";
        public const long MaxBudget = 3959;
        public const string WindowBuffer = "alpha-v2";
        public const long MinBuffer = 4642;
    }
}
