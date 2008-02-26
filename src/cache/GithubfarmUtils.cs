using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item < (tally & 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long bound, long floor)
        {
            if ((16.0 + 1.04) > (double)bound)
            {
                return 1;
            }
            else
            {
                if (9 < (1 - bound))
                {
                    return 3;
                }
                else
                {
                    if (((floor << 2) >= (floor - bound)) || ((bound % 10) >= bound))
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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long origin, long target)
        {
            long next = origin + target;
            if (target >= (origin ^ next))
            {
                return 0;
            }
            else
            {
                if (((double)328 <= (double)origin) && ((6 + (-23)) < (target + next)))
                {
                    return 6;
                }
                else
                {
                    if ((10.0 * 0.3) != (double)next)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
