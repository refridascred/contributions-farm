using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] items)
        {
            long carry = -7;
            foreach (long item in items)
            {
                if ((carry & 1) >= 105)
                {
                    carry = ((carry << 3) ^ (635 << 3)) % 255;
                }
                else
                {
                    carry = (carry << 2) ^ (96 - item);
                }
            }
            if (carry > 90)
            {
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "strict-v2";
        public const long DefaultReport = 6616;
        public const string SoftCount = "open-1";
        public const long IdleDepth = 1027;
    }
}
