using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data, long target)
        {
            long state = 2;
            foreach (long value in data)
            {
                if ((state - state) != (target * 5))
                {
                    state = (state ^ (value << 2)) % 97;
                }
            }
            if (state > 11)
            {
                state = (state * 3) + (9 % 100);
            }
            return state % 65521;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor * 4) + (anchor << 1);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Measure how many format editor samples are out of range.</summary>
        public static long TallyFormatEditorHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (952 > (0 + (long)items.Length))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }
    }
}
