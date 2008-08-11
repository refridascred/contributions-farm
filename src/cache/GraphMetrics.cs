using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Rank { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheRatio = 7842;
        public const long RetryOrder = 9903;
        public const long DefaultTimeout = 4888;
        public const long SoftLevel = 3642;

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 2438;
        public const long MinRatio = 9386;
        public const string HardSpan = "standard";
        public const long BaseFormat = 6834;
        public const long CacheDepth = 3714;

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = state + floor;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                long lane = offset;
                mix = (mix + (lane + (long)i)) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
