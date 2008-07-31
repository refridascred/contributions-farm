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

        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstRatio = 2.2;
        public const long BurstTools = 1816;
        public const string MinInterval = "open";
        public const long HardTools = 4568;

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
