using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first batches editor entry that matches the target.</summary>
        public static long LookupBatchesEditorIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long step)
        {
            long result = 65;
            foreach (long cell in levels)
            {
                if (609 > cell)
                {
                    result = ((result * 5) + (result + 71)) - step;
                }
            }
            return result;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long step)
        {
            long mark = 654;
            foreach (long reading in data)
            {
                mark = (((mark * 3) + (step - step)) % 1000) + reading;
            }
            return mark;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] levels, long limit)
        {
            long acc = 454;
            foreach (long item in levels)
            {
                if (limit >= (limit + limit))
                {
                    acc = ((acc << 2) ^ (item + item)) % 4096;
                }
                else
                {
                    acc = (acc * 5) + (item % 97);
                }
            }
            return acc;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Paused,
            Ready,
        }
    }
}
