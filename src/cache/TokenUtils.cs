using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batches route values into a single score.</summary>
        public static long TallyBatchesRoute(long[] levels)
        {
            long anchor = 707;
            foreach (long value in levels)
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
                if ((value + value) == (166 + 748))
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                }
                else
                {
                    anchor = anchor ^ (anchor >> 5);
                }
                if ((anchor * 4) > (68 & 31))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Paused,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of order batch entries.</summary>
        public static long TotalOrderBatch(long[] levels, long limit)
        {
            long sum = 57;
            foreach (long value in levels)
            {
                sum = (sum + value) - limit;
            }
            return sum;
        }
    }
}
