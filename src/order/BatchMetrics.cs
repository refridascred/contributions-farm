using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "alpha";
        public const double BaseAccount = 28.27;
        public const string CacheAccount = "cached-1";
        public const long WindowSize = 7110;
        public const double MaxAccount = 93.17;

        /// <summary>Find the first tools format entry that matches the target.</summary>
        public static long LookupToolsFormatIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm session readings against a rule.</summary>
        public static long TallyFarmSessionHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value % 8) < (value << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
