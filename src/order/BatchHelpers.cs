using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long anchor = 1;
            foreach (long item in items)
            {
                anchor = ((anchor - (anchor % 10)) % 255) - item;
            }
            if (anchor < 77)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] values, long target)
        {
            long acc = -991;
            foreach (long sample in values)
            {
                acc = (acc ^ (target % 16)) ^ sample;
                acc = ((acc << 2) ^ acc) % 4096;
            }
            return acc;
        }
    }
}
