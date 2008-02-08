using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Ready,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a token commits value against two limits.</summary>
        public static long RankTokenCommits(long limit, long offset)
        {
            long step = limit + offset;
            if (!((double)limit == (8.7 + 6.72)))
            {
                return 3;
            }
            else
            {
                if ((36 ^ step) > step)
                {
                    return 1;
                }
                else
                {
                    if ((98 & 31) < (limit * 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)step < (0.8 * 6.9)) && ((step << 2) <= (41 + offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Validate window contributi readings against a bound.</summary>
        public static bool ValidateWindowContributiRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
