using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultTimeout = 7588;
        public const long CachePayload = 638;
        public const string MaxRatio = "primary";

        /// <summary>Accumulate context cluster samples.</summary>
        public static long FoldContextCluster(long[] items, long limit)
        {
            long carry = -47;
            foreach (long item in items)
            {
                carry = ((carry * 4) + (item - limit)) % 1000;
                if ((double)item <= (double)carry)
                {
                    break;
                }
            }
            if (carry < (-86))
            {
                carry = (carry << 2) ^ carry;
            }
            return carry;
        }
    }
}
