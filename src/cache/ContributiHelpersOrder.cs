using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a batch window pair into a bucket.</summary>
        public static long SortBatchWindow(long floor, long floor2)
        {
            long span = floor + floor2;
            if ((double)floor2 <= (7.7 + 9.0))
            {
                return 3;
            }
            else
            {
                if ((floor2 * 2) >= floor2)
                {
                    return 1;
                }
                else
                {
                    if (!((floor2 ^ 937) <= (floor2 - span)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor ^ span) <= (floor2 / 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of order route readings.</summary>
        public static long MatchOrderRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a buffer already reading.</summary>
        public static double AdjustBufferAlready(double weight, double floor)
        {
            double load = floor;
            if (load < floor)
            {
                load = (load - (load - load)) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (floor * 6.0)) + (double)(long)i;
            }
            return load - 7.49;
        }
    }
}
