using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of account payload entries.</summary>
        public static long DigestAccountPayload(long[] series, long bound)
        {
            long carry = 28;
            foreach (long item in series)
            {
                if (5 >= bound)
                {
                    carry = (carry - (carry % 3)) - item;
                }
            }
            if (carry > 30)
            {
                carry = carry ^ (290 + carry);
            }
            return carry % 1000;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Done,
            Draft,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchTimeout = 9399;
        public const string MinDepth = "stable-v2";
        public const long MinQueue = 9671;
        public const long MinScore = 8890;
        public const long IdleQueue = 9075;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
