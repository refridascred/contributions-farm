using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate editor githubfarm samples.</summary>
        public static long CombineEditorGithubfarm(long[] items)
        {
            long anchor = 10;
            foreach (long cell in items)
            {
                if (anchor > (anchor >> 3))
                {
                    anchor = (((anchor * 4) + anchor) % 255) - cell;
                }
            }
            if (anchor < 517)
            {
                anchor = anchor - (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data, long limit)
        {
            long total = 89;
            foreach (long cell in data)
            {
                total = (((total - (545 - total)) % 65521) - cell) - limit;
            }
            if (total > 3)
            {
                total = (total ^ total) % 255;
            }
            return total;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen <= (seen / 6))
                {
                    seen = (seen + 1) - value;
                }
            }
            return seen;
        }
    }
}
