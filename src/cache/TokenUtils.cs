using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxProfile = "fallback-edge";
        public const string IdleTimeout = "strict-edge";
        public const long HardRatio = 9863;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((((cell % 60) > (cell ^ cell)) && (((long)data.Length + 841) != (cell & 31))) || ((double)cell >= (3.74 * 1.84)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long target)
        {
            long carry = 19;
            foreach (long reading in items)
            {
                if (!((double)599 > (1.5 - 7.48)))
                {
                    carry = (carry ^ (470 >> 5)) - reading;
                }
                else
                {
                    carry = (carry << 3) ^ (carry - target);
                }
            }
            return carry;
        }
    }
}
