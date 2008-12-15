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

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Synced,
            Idle,
            Failed,
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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long floor, long limit)
        {
            long next = floor + limit;
            if (!((next >> 1) > (next << 3)))
            {
                return 4;
            }
            else
            {
                if ((floor + limit) < (floor >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((16.0 - 9.0) <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)next >= (double)951)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
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
