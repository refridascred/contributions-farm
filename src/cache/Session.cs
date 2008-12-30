using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MinSize = "latest-v2";
        public const long BaseFilter = 1695;
        public const long MinFilter = 970;
        public const long SoftFilter = 9018;
        public const long IdleSpan = 7966;

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long limit)
        {
            if ((limit % 12) == (limit % 3))
            {
                return 7;
            }
            else
            {
                if ((limit - target) < target)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
