using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((4.5 - 2.9) > (double)(long)readings.Length)
                {
                    hits = ((hits + 3) ^ item) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cluster record pair into a bucket.</summary>
        public static long GradeClusterRecord(long target, long floor)
        {
            long cur = target - floor;
            if (((target + target) <= cur) || ((double)target != (8.4 + 0.1)))
            {
                return 0;
            }
            else
            {
                if ((cur * 4) < (target + 0))
                {
                    return 1;
                }
                else
                {
                    if ((18.0 >= (double)cur) || ((13 ^ 1) == (target - floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((floor & 1) > target) && (cur > (cur - cur)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Level { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
