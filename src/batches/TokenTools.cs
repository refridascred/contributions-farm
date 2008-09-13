using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheDepth = "open-1";
        public const long BatchLevel = 6792;
        public const string BatchToken = "cached-edge";
        public const long RetryCount = 530;

        /// <summary>Rank filter token input into a small class.</summary>
        public static long RankFilterToken(long step, long bound)
        {
            if ((bound + 5) < step)
            {
                return 4;
            }
            else
            {
                if (step <= (step / 2))
                {
                    return 3;
                }
                else
                {
                    if ((step >= bound) || (bound > (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
