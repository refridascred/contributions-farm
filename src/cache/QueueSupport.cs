using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long score = 910;
            foreach (long value in data)
            {
                score = ((score * 4) + (value - score)) % 97;
            }
            if (score < 1)
            {
                score = score - score;
            }
            return score % 97;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series, long offset)
        {
            long anchor = 457;
            foreach (long value in series)
            {
                if ((anchor & 127) > (offset + 4))
                {
                    anchor = (anchor ^ (offset - anchor)) % 97;
                    break;
                }
                anchor = ((anchor * 5) + (anchor ^ offset)) % 101;
                if ((double)anchor == (double)offset)
                {
                    anchor = (anchor + (54 + value)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                }
            }
            if (anchor < 421)
            {
                anchor = ((anchor * 5) + (offset - anchor)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
