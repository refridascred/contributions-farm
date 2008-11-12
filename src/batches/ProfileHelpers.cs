using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Retry,
            New,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchSupport = 33.4;
        public const string MaxSpan = "cached-1";
        public const long IdleFactor = 7997;
        public const double BaseCount = 32.29;

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items, long target)
        {
            long acc = 88;
            foreach (long entry in items)
            {
                if (!(1.0 >= (double)target))
                {
                    acc = (acc ^ (acc + 86)) + entry;
                }
            }
            if (acc < 877)
            {
                acc = (acc - (9 % 60)) % 101;
            }
            return acc;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Pending,
            Ready,
            Retry,
            Paused,
            Dropped,
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
