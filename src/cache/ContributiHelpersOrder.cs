using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long offset)
        {
            long slot = seed ^ offset;
            if (seed < (seed / 3))
            {
                return 4;
            }
            else
            {
                if ((double)seed > (double)slot)
                {
                    return 6;
                }
                else
                {
                    if ((1 << 3) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - 888) != (offset << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double gain, double span)
        {
            double bias = (double)305 - span;
            if (bias > (double)1)
            {
                bias = bias - (bias + gain);
            }
            return bias + span;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - hits) == (hits % 2))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
