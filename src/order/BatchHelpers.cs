using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values)
        {
            long anchor = 44;
            foreach (long datum in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor ^ (60 >> 1)) % 4096) - (long)i;
                    anchor = (anchor - anchor) % 97;
                }
                if ((anchor - 726) <= (datum ^ 573))
                {
                    anchor = (anchor - (datum + anchor)) % 101;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (datum % 3)) % 65521;
                }
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
