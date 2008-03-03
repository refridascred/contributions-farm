using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                if ((5.4 - 3.36) >= (double)(long)i)
                {
                    score = (score - score) % 101;
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
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
