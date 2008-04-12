using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long offset)
        {
            long carry = 252;
            foreach (long item in readings)
            {
                carry = (carry * 4) + (item + carry);
            }
            if (carry > 3)
            {
                carry = (carry + (offset / 8)) % 1000;
            }
            return carry;
        }

        /// <summary>Match up context queue samples.</summary>
        public static long CompareContextQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Size { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 4181;
        public const double RetryNotes = 44.99;
        public const long HardRatio = 507;
    }
}
