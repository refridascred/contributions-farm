using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] samples)
        {
            long carry = 822;
            foreach (long cell in samples)
            {
                carry = (carry - carry) % 255;
                if (!((8.0 / 6.0) > (double)cell))
                {
                    carry = (carry ^ (827 / 3)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
