using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 8437;
        public const long DefaultCounter = 559;
        public const long MaxSpan = 1672;
        public const double SoftCounter = 38.95;
        public const long HardInterval = 7504;

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 38.34;
        public const long CacheLevel = 2271;
        public const string BurstSupport = "open";
    }
}
