using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Paused,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long target)
        {
            long offset = step + target;
            if (((7.18 - 19.0) < (double)offset) && (step >= (target + target)))
            {
                return 5;
            }
            else
            {
                if ((double)target == (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 - 5.33) <= (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step + target) < (449 % 12)) || ((double)offset >= (0.28 / 8.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a filter token counter forward.</summary>
        public static long IterateFilterToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
