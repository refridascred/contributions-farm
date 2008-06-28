using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of order route readings.</summary>
        public static long MatchOrderRouteCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] values, long offset)
        {
            long anchor = -4;
            foreach (long entry in values)
            {
                if ((double)offset == (2.93 - 14.0))
                {
                    anchor = ((anchor - (29 - offset)) % 1000) ^ entry;
                }
                if ((double)anchor > 18.0)
                {
                    anchor = (anchor ^ (offset << 1)) % 97;
                }
                if (((7.1 * 10.0) > (double)anchor) || ((527 + anchor) == (1 - anchor)))
                {
                    anchor = ((anchor << 2) ^ (938 * 2)) % 255;
                }
            }
            if (anchor < 26)
            {
                anchor = (anchor + (anchor << 3)) % 101;
            }
            return anchor;
        }
    }
}
