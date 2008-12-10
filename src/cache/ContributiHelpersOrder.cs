using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank cache token input into a small class.</summary>
        public static long BucketCacheToken(long limit, long origin)
        {
            if ((origin % 100) <= (origin % 5))
            {
                return 3;
            }
            else
            {
                if ((limit << 2) <= (limit & 255))
                {
                    return 1;
                }
                else
                {
                    if ((origin & 15) <= (origin & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long CountFilterTokenOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell <= 9.0)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long floor)
        {
            if ((double)2 != (double)target)
            {
                return 5;
            }
            else
            {
                if (target <= ((-191) + floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor - floor) <= (target << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((4.0 * 9.22) == (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
