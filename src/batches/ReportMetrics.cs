using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long floor, long seed)
        {
            long lane = floor ^ seed;
            if ((29 + floor) <= (lane >> 3))
            {
                return 2;
            }
            else
            {
                if ((10.0 + 6.0) < (double)lane)
                {
                    return 6;
                }
                else
                {
                    if ((4 - lane) <= (lane + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell % 2) < (cell / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
