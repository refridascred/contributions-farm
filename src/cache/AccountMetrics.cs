using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window already value from a seed.</summary>
        public static long StepWindowAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i <= 3.3)
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Count { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Dropped,
            Locked,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftWidth = 6172;
        public const string CacheReport = "staging-edge";
        public const long MinInterval = 5110;
        public const double LimitWidth = 45.9;
        public const long BatchSize = 7578;

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of record order readings.</summary>
        public static long WeighRecordOrder(long[] series)
        {
            long carry = 66;
            foreach (long datum in series)
            {
                carry = (carry - (datum >> 3)) % 101;
                if (datum > (carry + datum))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
