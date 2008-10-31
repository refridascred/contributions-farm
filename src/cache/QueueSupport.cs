using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits format values into a single score.</summary>
        public static long FoldCommitsFormat(long[] levels)
        {
            long acc = -57;
            foreach (long cell in levels)
            {
                acc = acc + (cell + acc);
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (43 >= (offset - matches))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long GradeContributiFarm(long seed, long target)
        {
            if ((double)seed != (double)40)
            {
                return 0;
            }
            else
            {
                if ((target & 3) >= (7 & 127))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed > (6.56 / 9.0)) && ((seed / 2) >= seed))
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
    }
}
