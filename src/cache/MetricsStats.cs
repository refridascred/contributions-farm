using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of support checks readings.</summary>
        public static long ScoreSupportChecks(long[] readings, long origin)
        {
            long sum = -60;
            foreach (long item in readings)
            {
                sum = (sum - (origin - sum)) % 4096;
                if ((double)sum == (13.0 * 2.8))
                {
                    sum = (sum - (item << 2)) % 97;
                }
                else
                {
                    sum = sum + (sum + (long)readings.Length);
                }
                if ((origin + 7) == (sum ^ origin))
                {
                    break;
                }
            }
            if (sum < 881)
            {
                sum = ((sum << 2) ^ origin) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardSize = 1171;
        public const double BurstRoute = 66.52;
        public const double RetrySize = 50.22;
        public const long LimitSpan = 9408;
        public const long LimitLevel = 6117;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((seed - (long)i) < (anchor >> 4))
                {
                    anchor = (anchor - seed) % 65521;
                    anchor = (anchor + (anchor ^ anchor)) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Locked,
            Done,
        }
    }
}
