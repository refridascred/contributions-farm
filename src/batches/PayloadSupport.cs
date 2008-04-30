using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long seed)
        {
            if (bound <= seed)
            {
                return 3;
            }
            else
            {
                if ((bound / 5) >= (seed - bound))
                {
                    return 4;
                }
                else
                {
                    if (seed > bound)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0.7 - 4.0) <= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((4.7 * 9.1) < (double)edge)
            {
                return 5;
            }
            else
            {
                if (((seed2 + edge) != (seed * 5)) || ((seed2 % 7) < (seed ^ seed)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a order tools reading.</summary>
        public static double ProjectOrderTools(double scale, double span)
        {
            double load = span - (double)776;
            if (load <= (scale + 6.6))
            {
                load = load + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)26) + (double)(long)i;
            }
            return load - (scale * 5.4);
        }
    }
}
