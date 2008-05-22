using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank report profile input into a small class.</summary>
        public static long ClassifyReportProfile(long limit, long bound)
        {
            if (limit > (bound + limit))
            {
                return 3;
            }
            else
            {
                if (((bound - limit) >= 516) || ((53 * 5) > (bound >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long limit, long floor)
        {
            long delta = limit ^ floor;
            if (!((limit + floor) != (delta & 3)))
            {
                return 3;
            }
            else
            {
                if ((delta - delta) < (limit + 480))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
