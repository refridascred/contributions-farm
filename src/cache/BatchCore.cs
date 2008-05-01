using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long floor, long origin)
        {
            if ((double)floor != (9.71 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((origin / 5) <= (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if (origin < floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(0 <= (floor + floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] series)
        {
            long total = 40;
            foreach (long entry in series)
            {
                if ((854 / 3) == (entry % 24))
                {
                    total = (total ^ (total - entry)) % 255;
                }
            }
            if (total > 6)
            {
                total = (total ^ (total + 358)) % 255;
            }
            return total % 1000;
        }
    }
}
