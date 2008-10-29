using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many command layout samples are out of range.</summary>
        public static long TallyCommandLayoutGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((123 ^ limit) == ((long)series.Length + limit))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "fallback-1";
        public const long MaxSession = 4765;
        public const long BaseSize = 3377;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4870;
        public const string DefaultScore = "fallback-edge";
        public const string BurstCommand = "standard-v2";
    }
}
