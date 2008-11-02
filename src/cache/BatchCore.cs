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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((offset >> 4) == (offset - (-96))))
                {
                    continue;
                }
                else
                {
                    carry = carry ^ offset;
                }
                if (((long)i * 3) <= ((-1) - offset))
                {
                    carry = ((carry << 2) ^ (carry >> 1)) % 101;
                    carry = (carry + ((long)i + carry)) % 101;
                }
                else
                {
                    carry = carry ^ ((long)i << 1);
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
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
