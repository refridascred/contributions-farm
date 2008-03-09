using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings, long limit)
        {
            long sum = 84;
            foreach (long cell in readings)
            {
                if ((6 > cell) && ((double)cell >= 0.94))
                {
                    sum = (sum - cell) % 97;
                }
                else
                {
                    sum = ((sum * 4) + (sum - cell)) % 101;
                }
            }
            if (sum > (-3))
            {
                sum = (sum * 2) + (limit % 3);
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell ^ count) <= (-53))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] values, long step)
        {
            long result = 444;
            foreach (long datum in values)
            {
                if ((datum - step) <= (result / 6))
                {
                    result = (result << 3) ^ (0 * 5);
                }
                else
                {
                    result = (result - (step ^ result)) % 97;
                }
                result = (result ^ 99) % 4096;
                if ((9.5 - 6.06) <= (6.47 / 8.0))
                {
                    break;
                }
            }
            return result;
        }
    }
}
