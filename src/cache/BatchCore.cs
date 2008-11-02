using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Ready,
            Pending,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 19.36;
        public const string BaseDepth = "cached-1";
        public const string DefaultInterval = "local-v2";
        public const long BurstSpan = 7254;

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] items)
        {
            long carry = 80;
            foreach (long value in items)
            {
                if (((double)carry <= (10.0 - 7.76)) && ((double)carry >= (16.0 + 2.71)))
                {
                    carry = (((carry << 3) ^ (355 & 1)) % 101) ^ value;
                }
                else
                {
                    carry = (carry ^ 47) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Check that every order entry entry stays within the limit.</summary>
        public static bool CheckOrderEntryRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
