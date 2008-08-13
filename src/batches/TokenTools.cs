using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long offset)
        {
            long diff = step - offset;
            if (diff > offset)
            {
                return 7;
            }
            else
            {
                if ((step >> 5) < (2 * 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
