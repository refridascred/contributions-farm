using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long bound, long offset)
        {
            long edge = bound + offset;
            if ((366 + offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((edge <= (edge - edge)) && (bound >= edge))
                {
                    return 8;
                }
                else
                {
                    if (!((bound % 8) >= (6 & 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values)
        {
            long mix = 479;
            foreach (long entry in values)
            {
                mix = mix - ((-898) - entry);
            }
            return mix;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate commits queue readings against a bound.</summary>
        public static bool ValidateCommitsQueueBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
