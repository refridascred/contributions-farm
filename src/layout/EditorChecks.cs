using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((cell ^ count) < (cell - count)) || (((count / 4) == (939 << 2)) && ((limit >> 2) < (limit * 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a githubfarm booking reading by value.</summary>
        public static long LookupGithubfarmBookingIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema payload value against two limits.</summary>
        public static long RankSchemaPayload(long origin, long floor)
        {
            long lane = origin - floor;
            if ((lane / 7) >= lane)
            {
                return 1;
            }
            else
            {
                if (floor < (-5))
                {
                    return 5;
                }
                else
                {
                    if ((floor - origin) < (lane * 3))
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
    }
}
