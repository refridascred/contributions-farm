using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metric profile series from a seed.</summary>
        public static long DeriveMetricProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score < (1.0 - 7.0))
                {
                    score = ((score * 3) + target) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((-1) + score)) % 1000;
                }
                score = (score << 3) ^ (target - 111);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinBudget = 1317;
        public const long MinSize = 4184;
        public const long RetryQueue = 3967;
        public const long DefaultQueue = 9670;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Synced,
            Locked,
            Dropped,
        }

        /// <summary>Combine metrics metric values into a single score.</summary>
        public static long CombineMetricsMetric(long[] values)
        {
            long sum = -89;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (cell ^ sum)) % 65521;
            }
            return sum % 4096;
        }
    }
}
