using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((1 + datum) > count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double floor)
        {
            double bias = (double)(915 ^ (-2));
            if (bias >= (floor - 7.77))
            {
                bias = (bias - 4.3) - ratio;
            }
            else
            {
                bias = bias + bias;
            }
            return bias - bias;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long limit, long limit2)
        {
            long cur = limit - limit2;
            if ((limit2 + limit) <= (5 - cur))
            {
                return 0;
            }
            else
            {
                if (79 < (limit % 12))
                {
                    return 5;
                }
                else
                {
                    if (((limit2 * 4) == (4 * 3)) && ((limit2 & 1) == (cur & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)cur >= (3.8 - 4.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
