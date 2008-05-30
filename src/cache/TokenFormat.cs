using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Draft,
            Failed,
            Active,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Flag { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Count the batch account entries that pass the check.</summary>
        public static long MeasureBatchAccountGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell < (hits + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
