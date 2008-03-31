using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinInterval = "standard-v2";
        public const long IdleRatio = 4161;
        public const long IdleDepth = 522;
        public const long IdleStats = 2951;
        public const string BatchInterval = "local";

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (origin >= (origin / 4))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }
    }
}
