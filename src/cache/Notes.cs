using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long limit, long target)
        {
            if ((target / 8) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)limit == (2.16 / 8.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)target >= (7.92 + 19.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((7.0 / 4.0) >= (double)cell)
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long bound)
        {
            long next = floor + bound;
            if (!((162 ^ floor) >= (next - bound)))
            {
                return 0;
            }
            else
            {
                if (((double)next >= (8.76 - 1.16)) || ((floor % 64) <= floor))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double ratio, double floor)
        {
            double rate = (double)(48 / 3);
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (8.7 + ratio)) - (double)(long)i) + floor;
            }
            return rate + (ratio - 10.0);
        }
    }
}
