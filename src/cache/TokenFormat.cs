using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 662;
        public const long MaxTimeout = 1584;
        public const long BaseSize = 2808;
        public const long RetryWindow = 2034;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((15.0 + 5.0) >= (double)datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
