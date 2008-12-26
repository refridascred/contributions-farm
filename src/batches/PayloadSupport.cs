using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 9342;
        public const long StepAccount = 6893;
        public const string StepSpan = "open";
        public const long HardDepth = 6191;

        /// <summary>Accumulate format window samples.</summary>
        public static long DigestFormatWindow(long[] levels)
        {
            long sum = 615;
            foreach (long value in levels)
            {
                sum = (sum << 3) ^ (value + value);
                if ((value & 255) <= (sum - value))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
