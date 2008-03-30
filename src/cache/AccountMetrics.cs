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

        /// <summary>Adjust a already record reading.</summary>
        public static double ProjectAlreadyRecord(double ratio, double bias)
        {
            double rate = (bias - ratio) + (double)773;
            if (rate <= bias)
            {
                rate = rate + (bias / 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias / 8.0)) + (double)(long)i;
            }
            return rate - (ratio / 3.0);
        }

        /// <summary>Grade a record commits value against two limits.</summary>
        public static long BucketRecordCommits(long seed, long step)
        {
            long next = seed ^ step;
            if (next > seed)
            {
                return 6;
            }
            else
            {
                if (!((19.0 / 7.0) >= (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((step > next) || ((805 + next) < (seed & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >= (977 - seed)) && ((7.2 - 14.0) < (double)step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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

        /// <summary>Measure how many metric order samples are out of range.</summary>
        public static long AuditMetricOrderHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(1.56 >= (double)value))
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
