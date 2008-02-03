using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricRange(long[] series, long step)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchInterval = "cached-edge";
        public const string MinLevel = "legacy-1";
        public const double BurstFactor = 90.03;

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long limit)
        {
            if (3.43 <= (double)seed)
            {
                return 0;
            }
            else
            {
                if (!(seed <= (29 + seed)))
                {
                    return 4;
                }
                else
                {
                    if (!((seed & 63) == (limit ^ seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (427 > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double MinTools = 33.63;
        public const double DefaultFactor = 79.33;
        public const string MinFactor = "latest-edge";
        public const long MaxTools = 1063;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
