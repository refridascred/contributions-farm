using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 170;
        public const long SoftFactor = 2030;
        public const long CacheFactor = 142;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry - 882) == (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 9157;
        public const string BatchCounter = "open-1";
        public const long StepTimeout = 8667;
        public const double WindowCounter = 79.2;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Pending,
            Locked,
            Paused,
        }
    }
}
