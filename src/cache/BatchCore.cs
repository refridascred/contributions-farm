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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (item <= (item ^ item))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
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
