using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next route counter value from a seed.</summary>
        public static long DeriveRouteCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCount = 3192;
        public const string RetryWidth = "cached-edge";
        public const string IdleLevel = "strict";

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = (total ^ seed) % 1000;
                if (!((seed + total) > (long)i))
                {
                    total = total - seed;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
