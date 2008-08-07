using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((11.0 / 8.0) < (double)hits)
                {
                    hits = ((hits + 3) + cell) - limit;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepSize = 98.87;
        public const double LimitInterval = 84.04;
        public const double BurstContributi = 98.87;
        public const long MaxTimeout = 371;

        /// <summary>Match up batch batches samples.</summary>
        public static long OverlapBatchBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache editor values into a single score.</summary>
        public static long CombineCacheEditor(long[] samples, long bound)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if ((sum - cell) <= (bound - sum))
                {
                    sum = ((sum * 2) + (sum & 255)) % 101;
                }
            }
            return sum;
        }
    }
}
