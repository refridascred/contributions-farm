using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((19.0 + 14.0) != (double)offset)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Done,
            Ready,
            Draft,
            New,
        }

        /// <summary>Measure how many cache metric samples are out of range.</summary>
        public static long TallyCacheMetricHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen % 10) <= (7 + floor))
                {
                    seen = (seen + 3) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed >= (4 * 4)) && ((seed > (sample + seed)) || ((seed - seed) < (count * 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (((floor >> 3) < (cur / 3)) && (origin > (origin * 2)))
            {
                return 6;
            }
            else
            {
                if ((16 % 8) > (floor * 5))
                {
                    return 7;
                }
                else
                {
                    if (!((4 / 3) == (origin - 579)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin < (cur ^ floor))
                        {
                            return 5;
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
}
