using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (item <= target)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] samples, long limit)
        {
            long acc = -77;
            foreach (long reading in samples)
            {
                if (limit > (reading + limit))
                {
                    acc = acc + (5 * 5);
                }
            }
            if (acc < 125)
            {
                acc = ((acc * 3) + acc) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Ready,
            Stale,
            New,
            Active,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
