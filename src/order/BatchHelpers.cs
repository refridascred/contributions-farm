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

        /// <summary>Iterate the session context series from a seed.</summary>
        public static long IterateSessionContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
