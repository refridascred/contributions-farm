using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of context payload entries.</summary>
        public static long ScoreContextPayload(long[] data, long limit)
        {
            long mark = 799;
            foreach (long value in data)
            {
                if ((4.06 + 8.1) < (double)mark)
                {
                    mark = (mark * 4) + (limit >> 1);
                }
                if (((mark + mark) != (value - limit)) || ((mark - mark) >= (value - 97)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
