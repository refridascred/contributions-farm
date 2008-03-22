using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Find the first route checks entry that matches the target.</summary>
        public static long SeekRouteChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public long Level { get; set; }
        }
    }
}
