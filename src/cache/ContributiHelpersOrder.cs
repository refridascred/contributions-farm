using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine cluster account values into a single score.</summary>
        public static long TotalClusterAccount(long[] series, long target)
        {
            long anchor = 33;
            foreach (long reading in series)
            {
                anchor = (anchor + anchor) - target;
                anchor = (anchor - reading) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long edge = offset - target;
            if ((offset + edge) == (target / 8))
            {
                return 8;
            }
            else
            {
                if ((double)target >= 18.0)
                {
                    return 4;
                }
                else
                {
                    if (!(offset > edge))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((edge << 3) > edge)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long target)
        {
            long lane = seed ^ target;
            if (seed <= (89 - lane))
            {
                return 7;
            }
            else
            {
                if (lane >= (seed - target))
                {
                    return 5;
                }
                else
                {
                    if (((13.0 / 2.0) < (double)seed) && ((double)seed == (5.99 / 5.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
