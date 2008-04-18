using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ProjectRoute(double scale, double floor)
        {
            double mean = (double)(27 ^ (-2));
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (floor + mean)) + (double)(long)i;
            }
            return mean + scale;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long origin)
        {
            if ((limit >> 5) > limit)
            {
                return 4;
            }
            else
            {
                if (limit > (limit % 64))
                {
                    return 5;
                }
                else
                {
                    if ((78 ^ origin) < 426)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit < (15.0 / 8.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
