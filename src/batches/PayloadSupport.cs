using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a route window pair into a bucket.</summary>
        public static long GradeRouteWindow(long step, long offset)
        {
            long diff = step ^ offset;
            if (step > offset)
            {
                return 6;
            }
            else
            {
                if (((465 + diff) >= ((-831) * 3)) || ((77 + step) != (76 - step)))
                {
                    return 4;
                }
                else
                {
                    if ((double)diff <= (7.34 * 8.3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((offset + offset) != (93 % 7)))
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
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double ratio, double offset)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (ratio - ratio2)) + (double)(long)i;
            }
            return ratio2 - offset;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long seed, long step)
        {
            if ((seed - step) < (seed - seed))
            {
                return 7;
            }
            else
            {
                if ((2 * 2) != (seed + seed))
                {
                    return 3;
                }
                else
                {
                    if ((3.04 * 5.3) == (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
