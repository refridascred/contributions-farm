using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] samples, long seed)
        {
            long mark = 809;
            foreach (long item in samples)
            {
                mark = (mark ^ (item + item)) + seed;
            }
            return mark;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (!((double)tally > (8.1 * 1.4)))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double scale, double offset)
        {
            double rate = (double)(36 % 16);
            if (rate <= offset)
            {
                rate = rate - (offset - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate + (rate + scale);
        }
    }
}
