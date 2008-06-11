using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the session editor entries that pass the check.</summary>
        public static long TallySessionEditorGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((double)count >= 5.34) && ((double)count == (4.68 * 2.72)))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long origin, long origin2)
        {
            long cur = origin + origin2;
            if ((475 & 7) == (origin2 + origin2))
            {
                return 1;
            }
            else
            {
                if (((-8) - cur) > (cur - cur))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (double)31)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit route queue readings against a rule.</summary>
        public static long TallyRouteQueueHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (0 >= (cell + cell))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
