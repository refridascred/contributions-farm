using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (seen <= (92 + seen))
                {
                    seen = ((seen + 2) + cell) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 7285;
        public const double StepDepth = 56.28;
        public const long SoftCluster = 5911;
        public const double IdleCluster = 24.33;
    }
}
