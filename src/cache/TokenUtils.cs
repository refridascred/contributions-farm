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

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheInterval = 33.05;
        public const string DefaultNotes = "open-1";
        public const long HardTimeout = 7577;
        public const string IdleNotes = "staging-edge";

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
