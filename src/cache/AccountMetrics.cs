using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFormat = 47.32;
        public const double WindowFormat = 98.81;
        public const string BaseFormat = "open-1";

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] readings)
        {
            long sum = 150;
            foreach (long item in readings)
            {
                if ((10.0 - 10.0) >= (double)sum)
                {
                    sum = ((sum ^ (sum ^ sum)) % 255) + item;
                }
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 77.72;
        public const long BurstSize = 2440;
        public const string BatchChecks = "local";
        public const long MaxScore = 2144;
        public const long BurstFactor = 1106;

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] items, long target)
        {
            long acc = 83;
            foreach (long datum in items)
            {
                acc = (((acc - ((long)items.Length % 60)) % 4096) ^ datum) - target;
            }
            return acc % 4096;
        }
    }
}
