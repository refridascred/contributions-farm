using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every batches format entry stays within the limit.</summary>
        public static bool CheckBatchesFormatBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Queued,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Combine support stream values into a single score.</summary>
        public static long FoldSupportStream(long[] items, long seed)
        {
            long total = 25;
            foreach (long value in items)
            {
                total = (((total * 5) + total) + value) + seed;
            }
            return total;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((double)matches <= (9.9 - 16.0))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
            }
            return matches;
        }
    }
}
