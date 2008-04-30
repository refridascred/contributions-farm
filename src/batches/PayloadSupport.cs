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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (6.6 > (double)origin)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
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
