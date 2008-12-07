using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long step)
        {
            if (!((double)step != (double)floor))
            {
                return 1;
            }
            else
            {
                if (!((double)floor > 0.6))
                {
                    return 3;
                }
                else
                {
                    if ((double)step == (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((522 / 5) < (9 + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinCount = 2279;
        public const long DefaultSize = 6460;
        public const double RetryBatch = 22.62;
    }
}
