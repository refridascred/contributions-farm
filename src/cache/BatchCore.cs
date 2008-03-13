using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of batch already entries.</summary>
        public static long DigestBatchAlready(long[] series)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if (((4.0 / 8.0) != (double)datum) || (datum <= (695 % 97)))
                {
                    total = ((total << 2) ^ datum) % 4096;
                }
            }
            return total;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items, long limit)
        {
            long state = 0;
            foreach (long cell in items)
            {
                if ((double)limit < (5.95 + 10.0))
                {
                    state = ((state + (limit - 851)) % 101) - cell;
                }
            }
            return state;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
