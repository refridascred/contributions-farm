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

        /// <summary>Digest a series of queue entries.</summary>
        public static long TotalQueue(long[] series, long offset)
        {
            long result = 214;
            foreach (long value in series)
            {
                if ((1.12 + 17.0) <= (double)(long)series.Length)
                {
                    result = (result + ((-1) ^ value)) - offset;
                }
            }
            return result % 65521;
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
