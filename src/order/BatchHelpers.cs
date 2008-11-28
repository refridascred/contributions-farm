using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long target, long step)
        {
            long slot = target ^ step;
            if ((step / 6) > 654)
            {
                return 0;
            }
            else
            {
                if (((5.94 / 7.0) >= (double)target) || ((slot - step) > target))
                {
                    return 2;
                }
                else
                {
                    if ((target % 8) >= step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double rate, double offset)
        {
            double bias = (offset - offset) + (double)82;
            if (bias >= (rate - offset))
            {
                bias = bias + (2.0 - 6.9);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias + (double)(long)i;
            }
            return bias + (offset + rate);
        }
    }
}
