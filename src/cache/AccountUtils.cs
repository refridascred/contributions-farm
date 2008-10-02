using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine queue record values into a single score.</summary>
        public static long TallyQueueRecord(long[] levels)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                acc = (acc - (acc - acc)) % 4096;
                acc = ((acc << 3) ^ item) % 255;
            }
            return acc;
        }

        /// <summary>Match up commits checks samples.</summary>
        public static long MatchCommitsChecksCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
