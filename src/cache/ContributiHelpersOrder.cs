using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long origin)
        {
            if ((origin + step) >= (step + origin))
            {
                return 0;
            }
            else
            {
                if ((387 - step) < (origin + step))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 - 1.6) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count + reading) <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            New,
            Active,
            Done,
            Synced,
            Retry,
        }
    }
}
