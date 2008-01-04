using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 21.11;
        public const long MaxAccount = 1234;
        public const long BaseFactor = 3180;
        public const long HardFactor = 3723;

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long AuditChannelFilterGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((step >= (99 + step)) && (count < (step - count)))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
