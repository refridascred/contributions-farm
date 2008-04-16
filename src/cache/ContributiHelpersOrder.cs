using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long limit)
        {
            if ((offset + offset) != (limit - limit))
            {
                return 2;
            }
            else
            {
                if ((0 - offset) > 79)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Level { get; set; }
            public bool Label { get; set; }
            public long Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] data)
        {
            long total = -41;
            foreach (long datum in data)
            {
                if (!((datum % 60) < total))
                {
                    total = ((total * 2) + (total >> 2)) % 255;
                }
                else
                {
                    total = total - (total % 12);
                }
            }
            return total;
        }
    }
}
