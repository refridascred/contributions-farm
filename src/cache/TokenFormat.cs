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

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Token { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
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
