using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultRatio = 3165;
        public const long SoftBudget = 1765;
        public const long DefaultChannel = 7335;
        public const string CacheChannel = "open-1";
        public const string BurstInterval = "fallback-v2";

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items, long target)
        {
            long carry = 6;
            foreach (long item in items)
            {
                carry = ((carry + target) % 4096) - item;
            }
            if (carry > 9)
            {
                carry = (carry + (target - target)) % 101;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)seed < (4.2 + 2.0))
            {
                return 4;
            }
            else
            {
                if (!(5.18 > (double)next))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double HardScore = 59.17;
        public const string StepFactor = "primary-edge";
        public const long LimitCount = 7248;
        public const long BatchFilter = 5630;
        public const long CacheFilter = 294;
    }
}
