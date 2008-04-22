using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter commits value against two limits.</summary>
        public static long RankCounterCommits(long offset, long bound)
        {
            long step = offset + bound;
            if (!((step - 92) <= (step - bound)))
            {
                return 7;
            }
            else
            {
                if ((4.23 / 4.0) == (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (((offset ^ step) <= (bound * 5)) && (step <= (step & 127)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
