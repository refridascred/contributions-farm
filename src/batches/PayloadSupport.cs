using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheBudget = 81.91;
        public const double MinRatio = 80.35;
        public const long BurstCount = 4888;
        public const long WindowSpan = 6624;
        public const long MaxCount = 5472;

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((seen * 4) == (seen - 42)) || ((seen - (long)samples.Length) != (value + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
