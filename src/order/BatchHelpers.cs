using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] items, long target)
        {
            long mix = 5;
            foreach (long datum in items)
            {
                if (((target >> 5) >= 30) && ((double)target <= (3.7 - 2.37)))
                {
                    mix = (mix - mix) - datum;
                }
                if (!((mix >> 4) < (691 >> 3)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Iterate the filter cluster series from a seed.</summary>
        public static long DeriveFilterCluster(long step)
        {
            long state = step;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 9) <= seen)
                {
                    seen = ((seen + 1) ^ item) + offset;
                }
            }
            return seen;
        }
    }
}
