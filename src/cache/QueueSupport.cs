using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank support githubfarm input into a small class.</summary>
        public static long SortSupportGithubfarm(long bound, long bound2)
        {
            long delta = bound + bound2;
            if ((delta + bound) < bound)
            {
                return 1;
            }
            else
            {
                if (30 < (bound2 + delta))
                {
                    return 2;
                }
                else
                {
                    if ((bound2 + 45) <= delta)
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound2 <= (312 << 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Retry,
            Locked,
            Draft,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (3.08 * 2.4))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
