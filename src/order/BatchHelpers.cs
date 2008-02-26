using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long floor)
        {
            if ((5.0 + 6.8) != (double)target)
            {
                return 5;
            }
            else
            {
                if (floor < (target + floor))
                {
                    return 1;
                }
                else
                {
                    if ((1.03 - 1.21) != (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target >> 1) != (target >> 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double floor)
        {
            double mean = floor + (6.0 * 9.42);
            if (mean < floor)
            {
                mean = (mean - (double)23) - weight;
            }
            return mean - (mean * 5.5);
        }

        /// <summary>Measure how many token schema samples are out of range.</summary>
        public static long MeasureTokenSchemaHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)datum != (16.0 - 1.0))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
