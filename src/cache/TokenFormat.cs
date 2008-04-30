using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches * 2) != (datum + datum)) && (((datum & 3) < (datum & 15)) && ((10 + datum) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)seen > (6.1 - 7.69)))
                {
                    seen = ((seen + 2) + datum) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Size { get; set; } = "";
            public double Owner { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
