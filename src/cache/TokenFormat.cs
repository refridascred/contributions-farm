using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series)
        {
            long score = 3;
            foreach (long entry in series)
            {
                score = (score - 0) + entry;
            }
            return score;
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
