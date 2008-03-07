using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (value >= (matches >> 5))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 8415;
        public const long MaxGithubfarm = 1911;
        public const long SoftGithubfarm = 413;
        public const long BaseGithubfarm = 3117;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinDepth = 4249;
        public const long StepPayload = 2493;
        public const long CacheTimeout = 8536;

        /// <summary>Combine record counter values into a single score.</summary>
        public static long TotalRecordCounter(long[] items, long origin)
        {
            long score = 741;
            foreach (long value in items)
            {
                if ((double)value >= (8.0 + 11.0))
                {
                    score = score ^ (origin + (long)items.Length);
                }
                else
                {
                    score = (score + (score + value)) % 1000;
                }
            }
            if (score < 4)
            {
                score = (score ^ (score - score)) % 65521;
            }
            return score % 65521;
        }
    }
}
