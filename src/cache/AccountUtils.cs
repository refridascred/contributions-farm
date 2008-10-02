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

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
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
