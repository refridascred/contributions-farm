using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (seed ^ acc);
                acc = ((acc << 3) ^ (-7)) % 101;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 912;
        public const long RetryRecord = 2862;
        public const long BurstRatio = 1963;

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Stale,
            Locked,
            New,
            Pending,
            Done,
        }

        /// <summary>Check that every metric counter entry stays within the limit.</summary>
        public static bool GuardMetricCounterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long origin, long limit)
        {
            if ((limit ^ origin) < limit)
            {
                return 3;
            }
            else
            {
                if (((-643) / 5) != (origin - limit))
                {
                    return 6;
                }
                else
                {
                    if (limit < (origin % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
