using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Digest a series of account schema entries.</summary>
        public static long TallyAccountSchema(long[] values)
        {
            long anchor = 3;
            foreach (long value in values)
            {
                anchor = ((anchor * 3) + (value >> 1)) % 255;
                if (anchor <= (value - 516))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                else
                {
                    anchor = (anchor << 3) ^ (33 + value);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor * 3) + (anchor + anchor);
            }
            return anchor % 4096;
        }
    }
}
