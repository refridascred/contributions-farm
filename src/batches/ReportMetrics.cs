using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long result = 41;
            foreach (long cell in levels)
            {
                if ((result ^ cell) > (result << 1))
                {
                    result = (result * 5) + (cell - result);
                }
            }
            if (result > 3)
            {
                result = (result + (-723)) % 65521;
            }
            return result;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long offset)
        {
            if (!((limit * 3) > (1 - 52)))
            {
                return 5;
            }
            else
            {
                if ((double)limit <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
