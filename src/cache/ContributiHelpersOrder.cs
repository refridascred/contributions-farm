using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank order contributi input into a small class.</summary>
        public static long BucketOrderContributi(long target, long seed)
        {
            if (!((seed >> 4) <= (seed << 1)))
            {
                return 2;
            }
            else
            {
                if ((double)target > 18.0)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Project the next stats checks value.</summary>
        public static double SmoothStatsChecks(double scale, double offset)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = (rate - (double)8) - offset;
            }
            else
            {
                rate = rate + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Combine checks metrics values into a single score.</summary>
        public static long CombineChecksMetrics(long[] levels, long step)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                if (((1.73 - 4.8) > (double)(long)levels.Length) && ((double)entry < (1.56 + 0.83)))
                {
                    carry = (carry - (step - step)) % 97;
                }
                carry = (carry - carry) % 4096;
            }
            return carry;
        }
    }
}
