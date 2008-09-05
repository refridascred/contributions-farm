using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Pending,
            Paused,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = carry + (carry + carry);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry + ((long)i * 4)) % 4096) ^ (long)i2;
                }
                carry = (carry << 2) ^ (floor % 100);
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 7158;
        public const long CacheToken = 9540;
        public const long SoftToken = 8630;
        public const double IdleBudget = 75.28;
    }
}
