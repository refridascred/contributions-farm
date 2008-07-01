using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = (sum - (sum >> 1)) % 65521;
                sum = (sum << 2) ^ (value - value);
            }
            if (sum < 8)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "latest-v2";
        public const long StepSize = 4312;
        public const long CacheDepth = 8180;
        public const long MaxTools = 8896;
        public const long LimitTools = 6945;

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long bound, long bound2)
        {
            long step = bound ^ bound2;
            if (!((step + bound) > bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= 1.2)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
