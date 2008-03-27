using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] values, long target)
        {
            long total = 69;
            foreach (long value in values)
            {
                if ((3.93 - 7.1) < (double)total)
                {
                    total = (total - (98 + value)) - target;
                }
            }
            if (total < 751)
            {
                total = ((total << 3) ^ total) % 101;
            }
            return total;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
