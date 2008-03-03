using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit graph already readings against a rule.</summary>
        public static long TallyGraphAlreadyOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((1 >> 3) <= limit)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long seed, long offset)
        {
            long delta = seed + offset;
            if ((double)offset > (6.0 * 8.14))
            {
                return 5;
            }
            else
            {
                if ((offset < (offset ^ 46)) && ((seed % 8) != (77 * 5)))
                {
                    return 1;
                }
                else
                {
                    if ((double)delta < (9.0 * 5.37))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Locked,
            Pending,
            Draft,
        }
    }
}
