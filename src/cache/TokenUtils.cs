using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] samples, long target)
        {
            long sum = 309;
            foreach (long item in samples)
            {
                if (!(sum > (sum + sum)))
                {
                    sum = ((sum << 3) ^ (target + 92)) ^ item;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            Paused,
            Stale,
            Synced,
            Ready,
        }
    }
}
