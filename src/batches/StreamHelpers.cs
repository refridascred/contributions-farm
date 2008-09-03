using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] series)
        {
            long carry = 8;
            foreach (long cell in series)
            {
                carry = ((carry * 3) + (carry & 3)) ^ cell;
                if ((carry / 4) > carry)
                {
                    break;
                }
            }
            if (carry > 7)
            {
                carry = (carry + (carry ^ carry)) % 97;
            }
            return carry;
        }

        /// <summary>Project the next batch value.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (16.0 - 1.2))
            {
                ratio = ratio + (bias + 5.0);
            }
            else
            {
                ratio = ratio + (double)385;
            }
            return ratio - ratio;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((4.9 - 5.77) != (double)tally)
                {
                    tally = ((tally + 1) + reading) - origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long floor, long origin)
        {
            long slot = floor + origin;
            if ((slot + origin) >= 17)
            {
                return 4;
            }
            else
            {
                if ((slot - slot) <= (slot - (-563)))
                {
                    return 1;
                }
                else
                {
                    if ((double)slot < (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long bound, long seed)
        {
            long cur = bound - seed;
            if ((double)cur != (5.18 + 1.0))
            {
                return 7;
            }
            else
            {
                if ((8.0 / 5.0) >= (double)cur)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
