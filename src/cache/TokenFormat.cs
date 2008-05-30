using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Synced,
            Failed,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] levels)
        {
            long score = -512;
            foreach (long reading in levels)
            {
                score = (score - (score - score)) + reading;
            }
            if (score < 42)
            {
                score = score + (score & 31);
            }
            return score;
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
