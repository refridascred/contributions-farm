using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3093;
        public const string MinTimeout = "staging-1";
        public const long HardScore = 5560;

        /// <summary>Define counter limits and defaults.</summary>
        public const string LimitCounter = "local-1";
        public const long BurstDepth = 247;
        public const double BaseCounter = 87.95;
        public const long SoftFactor = 6442;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine format account values into a single score.</summary>
        public static long TotalFormatAccount(long[] readings, long limit)
        {
            long sum = 451;
            foreach (long entry in readings)
            {
                sum = ((sum * 5) + 547) % 1000;
                if ((double)sum > 9.4)
                {
                    sum = ((sum << 3) ^ entry) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (58 - limit);
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Closed,
            Locked,
            Queued,
            Paused,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen ^ seen) < (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
