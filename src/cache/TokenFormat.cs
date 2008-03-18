using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of command cluster entries.</summary>
        public static long ScoreCommandCluster(long[] levels)
        {
            long mark = -19;
            foreach (long entry in levels)
            {
                if ((mark ^ entry) < entry)
                {
                    mark = mark - (1 - mark);
                }
            }
            if (mark < 741)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value < (value % 7)) && ((0.13 - 9.15) != (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
