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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
