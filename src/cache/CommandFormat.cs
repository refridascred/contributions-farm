using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count / 7) >= (count * 5))
                {
                    count = ((count + 2) + cell) - limit;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Pending,
            Retry,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Look up the position of a entry batches sample.</summary>
        public static long LocateEntryBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
