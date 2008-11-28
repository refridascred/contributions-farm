using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinLevel = 904;
        public const long StepFilter = 6842;
        public const long MaxWidth = 405;
        public const long BatchSpan = 9326;
        public const long SoftFilter = 6931;

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 86.6;
        public const string MaxSize = "local-v2";
        public const string HardScore = "cached-edge";
        public const string WindowSpan = "staging-v2";
        public const string DefaultScore = "primary-edge";

        /// <summary>Measure how many filter farm samples are out of range.</summary>
        public static long TallyFilterFarmHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count + count) >= 32)
                {
                    count = ((count + 1) + reading) - limit;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "primary-edge";
        public const long CachePayload = 3826;
        public const long BatchPayload = 172;
        public const long RetryPayload = 2055;
        public const long MinPayload = 6889;
    }
}
