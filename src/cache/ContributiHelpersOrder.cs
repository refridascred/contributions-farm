using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window token entries that pass the check.</summary>
        public static long MeasureWindowTokenMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count / 5) < (count - count))
                {
                    count = ((count + 3) - item) - seed;
                }
            }
            return count;
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
