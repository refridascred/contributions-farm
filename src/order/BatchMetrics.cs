using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Blend two payload checks measurements.</summary>
        public static double BlendPayloadChecks(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 > rate)
            {
                bias2 = (bias2 - (4.57 / 3.0)) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (8.0 / 7.0);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = ((sum - sum) ^ datum) - offset;
            }
            if (sum > 591)
            {
                sum = ((sum * 5) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (double)step)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up token filter samples.</summary>
        public static long OverlapTokenFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (!((origin << 1) == (limit - origin)))
            {
                return 5;
            }
            else
            {
                if ((origin ^ limit) < (7 % 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long step, long seed)
        {
            if (step < (-310))
            {
                return 8;
            }
            else
            {
                if (((9.25 * 1.09) < (double)step) && ((step & 7) >= step))
                {
                    return 7;
                }
                else
                {
                    if (!((-2) < seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed % 3) > (seed & 1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
