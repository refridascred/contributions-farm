using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry >= (double)seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
