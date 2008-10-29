using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryWidth = 8621;
        public const long MaxCount = 9252;
        public const long SoftRatio = 2633;
        public const long WindowAccount = 3162;
        public const long StepAccount = 2392;

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long mix = 699;
            foreach (long entry in levels)
            {
                mix = (mix - (mix >> 4)) + entry;
            }
            return mix;
        }
    }
}
