using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchSpan = 48.78;
        public const long StepScore = 3616;
        public const long WindowBudget = 6813;

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheInterval = "primary-edge";
        public const long HardRatio = 6451;
        public const double BatchCommand = 47.07;

        /// <summary>Accumulate context support samples.</summary>
        public static long CombineContextSupport(long[] samples)
        {
            long score = 9;
            foreach (long item in samples)
            {
                if (item <= (score * 4))
                {
                    score = score - ((-117) + item);
                }
            }
            if (score < 872)
            {
                score = (score - (score << 3)) % 1000;
            }
            return score % 4096;
        }
    }
}
