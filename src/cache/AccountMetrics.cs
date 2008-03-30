using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Rank stats record input into a small class.</summary>
        public static long GradeStatsRecord(long bound, long seed)
        {
            if (((bound & 15) != (seed - 225)) && ((242 / 4) > (bound * 2)))
            {
                return 5;
            }
            else
            {
                if ((seed - 113) <= (bound << 3))
                {
                    return 3;
                }
                else
                {
                    if (seed < (seed & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long carry = 210;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry * 5) + (cell / 5)) % 65521) ^ (long)i;
                }
                if (!((4.3 * 0.1) <= (double)cell))
                {
                    carry = ((carry * 2) + (350 & 127)) % 97;
                }
            }
            if (carry > 9)
            {
                carry = ((carry * 4) + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double rate = span;
            return (rate - (double)60) + bias;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) < ((long)values.Length + datum))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
