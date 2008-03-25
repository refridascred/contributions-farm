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

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] readings)
        {
            long acc = 74;
            foreach (long sample in readings)
            {
                if (((sample + 1) == (acc - sample)) && ((double)sample < 5.1))
                {
                    acc = (acc << 2) ^ (sample % 60);
                }
            }
            if (acc > 422)
            {
                acc = acc ^ 11;
            }
            return acc % 65521;
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
