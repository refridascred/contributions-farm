using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((datum - 2) > datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long RankEditorBuffer(long floor, long limit)
        {
            if ((floor & 7) >= floor)
            {
                return 7;
            }
            else
            {
                if (((limit << 2) == (limit + limit)) && ((limit & 1) > (limit ^ 70)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetryFactor = "alpha-1";
        public const long BaseFactor = 4545;
        public const long BatchMetric = 4267;
    }
}
