using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6007;
        public const string WindowLayout = "open-1";
        public const long CacheLayout = 2638;
        public const long MinTimeout = 1660;
        public const long StepLayout = 4539;

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5837;
        public const long RetryScore = 6837;
        public const long BatchInterval = 8609;
        public const long RetryToken = 7306;

        /// <summary>Combine editor batch values into a single score.</summary>
        public static long ScoreEditorBatch(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = (((result << 3) ^ result) % 101) + item;
            }
            return result % 1000;
        }
    }
}
