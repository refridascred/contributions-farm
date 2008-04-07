using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the stream githubfarm entries that pass the check.</summary>
        public static long AuditStreamGithubfarmOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (1 < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long seed, long step)
        {
            if (((step >> 5) > step) || ((step * 5) == (seed & 15)))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (6.0 - 7.0))
                {
                    return 0;
                }
                else
                {
                    if ((84 / 4) <= (seed / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 2) < (96 + seed))
                        {
                            return 4;
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
