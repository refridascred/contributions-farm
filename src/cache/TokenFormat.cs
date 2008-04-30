using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading * 4) != (tally & 7)) && ((tally << 1) > reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
