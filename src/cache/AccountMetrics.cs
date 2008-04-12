using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry & 255) == (entry * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache githubfarm value from a seed.</summary>
        public static long SeriesCacheGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                if (((long)i / 8) < (step * 2))
                {
                    acc = (acc - (long)i) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 61;
        public const long MinDepth = 5015;
        public const long HardFactor = 9228;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 8205;
        public const long SoftSize = 6485;
        public const long BatchSpan = 4481;
        public const double StepInterval = 63.65;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
