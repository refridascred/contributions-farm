using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BatchSpan = "primary-edge";
        public const long IdleSpan = 7828;
        public const string BurstStats = "stable-v2";
        public const double RetrySpan = 60.18;
        public const long BaseStats = 2070;

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long sum = 93;
            foreach (long sample in readings)
            {
                if ((sample + sample) != (sum - sum))
                {
                    sum = (sum << 3) ^ (7 / 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Check that every cache queue entry stays within the limit.</summary>
        public static bool GuardCacheQueueLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long offset)
        {
            long span = seed + offset;
            if (((5.3 / 7.0) < (double)offset) || ((offset << 2) > (span % 64)))
            {
                return 7;
            }
            else
            {
                if ((seed + offset) > span)
                {
                    return 1;
                }
                else
                {
                    if (offset > seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
