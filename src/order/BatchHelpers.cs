using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long bound)
        {
            if ((double)target == (2.4 - 2.94))
            {
                return 0;
            }
            else
            {
                if ((bound / 8) != (bound + 9))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the profile report entries that pass the check.</summary>
        public static long TallyProfileReportOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)hits < (4.75 - 7.6)) || !(offset > (offset - offset)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }
    }
}
