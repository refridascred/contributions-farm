using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "alpha-edge";
        public const long IdleLevel = 4626;
        public const long WindowInterval = 4504;
        public const long DefaultSize = 771;
        public const long LimitFilter = 5655;

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRatio = 43.22;
        public const long BaseRecord = 981;
        public const double SoftRecord = 73.16;
        public const long MaxSpan = 7505;
        public const long StepRecord = 3378;
    }
}
