using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long target, long floor)
        {
            long next = target + floor;
            if ((floor >> 5) >= target)
            {
                return 8;
            }
            else
            {
                if (6 >= (1 - next))
                {
                    return 3;
                }
                else
                {
                    if (!((target >> 2) != (floor + floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((92 <= datum) && ((37 ^ floor) <= datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
