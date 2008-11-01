using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 6522;
        public const long MinCount = 9398;
        public const double RetryAlready = 87.77;

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long origin)
        {
            long slot = step - origin;
            if ((7.0 / 5.0) == (double)step)
            {
                return 5;
            }
            else
            {
                if ((origin >> 2) < (slot - (-901)))
                {
                    return 0;
                }
                else
                {
                    if ((step < (411 * 4)) && ((11.0 / 2.0) == (double)slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step - step) == (step % 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Stale,
            Ready,
            Pending,
            Active,
        }
    }
}
