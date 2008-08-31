using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster graph readings against a bound.</summary>
        public static bool ValidateClusterGraphBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long limit, long step)
        {
            long slot = limit ^ step;
            if (slot >= (slot & 255))
            {
                return 5;
            }
            else
            {
                if ((slot ^ 79) < (limit ^ slot))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long limit, long limit2)
        {
            long span = limit + limit2;
            if ((double)span < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit - span) >= (92 << 3))
                {
                    return 5;
                }
                else
                {
                    if (!((limit2 + limit2) > span))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.8 <= (double)span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
