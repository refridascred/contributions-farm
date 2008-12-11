using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long seed, long seed2)
        {
            if ((44 - 11) <= (seed2 << 2))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) < (269 + seed2))
                {
                    return 8;
                }
                else
                {
                    if ((seed & 15) <= seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((7 >= seed2) && ((7.74 - 5.0) != (double)seed2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double load = scale;
            if (load < (3.5 - 9.52))
            {
                load = (load + load) + span;
            }
            else
            {
                load = load + (double)(-6);
            }
            return load - load;
        }
    }
}
