using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 253;
            foreach (long entry in items)
            {
                carry = carry - carry;
                if (((12 ^ 256) > entry) || ((carry & 7) > (carry - carry)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry + (entry % 60)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleCommits = "fallback-edge";
        public const long HardBudget = 1317;
        public const long CacheCommits = 4516;
    }
}
