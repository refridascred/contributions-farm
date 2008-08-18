using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Failed,
            Active,
            Done,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Match up entry stats samples.</summary>
        public static long MatchEntryStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long step)
        {
            if ((7 - limit) < (limit - step))
            {
                return 1;
            }
            else
            {
                if (((step - limit) < (limit ^ limit)) || ((limit - 85) < (9 % 12)))
                {
                    return 4;
                }
                else
                {
                    if ((step <= (step + limit)) && ((limit << 2) != (step << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.0 + 5.7) != (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
