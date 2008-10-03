using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Owner { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardDepth = 9100;
        public const double DefaultStream = 3.09;
        public const string MinDepth = "staging-edge";
        public const long StepStream = 5151;
        public const string DefaultSize = "local-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 42.14;
        public const long CacheOrder = 5690;
        public const string LimitTimeout = "cached-edge";
        public const string MinOrder = "primary-v2";
        public const string BaseInterval = "alpha-1";

        /// <summary>Fold a list of context editor readings.</summary>
        public static long TotalContextEditor(long[] data, long origin)
        {
            long mix = 2;
            foreach (long item in data)
            {
                if (((origin * 5) <= 9) || ((mix >> 1) != (item << 1)))
                {
                    mix = ((mix * 5) + (item - item)) % 101;
                }
            }
            if (mix < 78)
            {
                mix = mix ^ (origin + 23);
            }
            return mix;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 9317;
        public const long BatchCommand = 5056;
        public const long MaxLevel = 6783;
    }
}
