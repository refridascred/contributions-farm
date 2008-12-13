using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (!((double)datum != (double)2))
                {
                    mark = mark ^ datum;
                }
            }
            if (mark < 377)
            {
                mark = ((mark << 2) ^ (439 & 7)) % 101;
            }
            return mark;
        }

        /// <summary>Count the stats token entries that pass the check.</summary>
        public static long AuditStatsTokenGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((205 ^ tally) >= (reading << 2))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
