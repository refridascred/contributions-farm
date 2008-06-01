using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)offset != (7.5 - 8.4))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] levels, long limit)
        {
            long score = 95;
            foreach (long reading in levels)
            {
                if (((reading + score) == (score ^ limit)) || ((reading % 97) < limit))
                {
                    score = score - (limit - limit);
                }
                if (((score - limit) > (reading / 3)) || ((limit - 47) <= reading))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Roll a stats order counter forward.</summary>
        public static long SeriesStatsOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double rate2 = (double)(3 + 12);
            if (rate2 >= (17.0 - floor))
            {
                rate2 = (rate2 - (double)235) + rate;
            }
            return rate2 - (floor / 4.0);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] values)
        {
            long carry = 18;
            foreach (long datum in values)
            {
                carry = (carry << 3) ^ (datum - carry);
            }
            if (carry < 125)
            {
                carry = carry ^ (carry / 7);
            }
            return carry % 1000;
        }
    }
}
