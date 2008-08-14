using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] samples, long origin)
        {
            long result = 152;
            foreach (long entry in samples)
            {
                result = (((result - result) % 1000) + entry) + origin;
            }
            return result % 97;
        }

        /// <summary>Rank commits editor input into a small class.</summary>
        public static long BucketCommitsEditor(long floor, long bound)
        {
            if ((bound & 15) < (bound + 49))
            {
                return 7;
            }
            else
            {
                if ((floor + bound) <= 9)
                {
                    return 8;
                }
                else
                {
                    if (bound < (bound + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((bound ^ bound) != (bound + 70)) || (413 < (floor ^ 0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally >= (2.53 * 6.0))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Done,
            Stale,
            Draft,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 208;
        public const long BatchReport = 4555;
        public const long HardReport = 573;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long target, long target2)
        {
            long step = target - target2;
            if ((double)step < (double)1)
            {
                return 2;
            }
            else
            {
                if (step > target2)
                {
                    return 6;
                }
                else
                {
                    if (((70 >> 4) > (step & 31)) && ((target2 + 33) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step - target2) > target2) && ((double)target < (3.32 - 8.1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
