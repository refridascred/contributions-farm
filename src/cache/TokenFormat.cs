using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                if ((2.9 / 4.0) >= (double)carry)
                {
                    carry = ((carry + 48) % 101) - datum;
                }
            }
            return carry;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = result + ((long)i - floor);
                if ((4.6 / 7.0) != (double)result)
                {
                    break;
                }
                else
                {
                    result = result ^ (floor * 4);
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit stream counter readings against a rule.</summary>
        public static long AuditStreamCounterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((double)seen >= (2.88 / 8.0)) && (((double)reading <= (5.84 / 3.0)) && (7.74 >= (double)reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
