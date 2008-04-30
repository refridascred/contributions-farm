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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count <= (6.6 / 8.0))
                {
                    count = ((count + 2) ^ cell) - step;
                }
            }
            return count;
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
