using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen > (entry >> 5))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultTimeout = 1790;
        public const long MinCommand = 6453;
        public const long WindowCommand = 9252;
    }
}
