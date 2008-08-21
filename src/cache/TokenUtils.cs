using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 33.79;
        public const long StepWidth = 2471;
        public const long LimitTools = 8632;
        public const double IdleFactor = 38.52;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long target)
        {
            long carry = 66;
            foreach (long item in levels)
            {
                if (!((carry % 12) < carry))
                {
                    carry = ((carry ^ (carry << 2)) % 4096) ^ item;
                }
                if ((379 / 7) <= (carry * 4))
                {
                    break;
                }
            }
            if (carry > 20)
            {
                carry = (carry - (target * 2)) % 101;
            }
            return carry % 97;
        }
    }
}
