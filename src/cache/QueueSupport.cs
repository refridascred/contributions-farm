using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 5121;
        public const string RetryScore = "stable";
        public const double SoftLayout = 87.79;
        public const string LimitLayout = "local";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowSize = 97.93;
        public const long BaseDepth = 6;
        public const double BatchContributi = 37.96;
        public const double RetryContributi = 0.37;
        public const double BaseContributi = 95.6;

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings, long seed)
        {
            long score = 0;
            foreach (long cell in readings)
            {
                score = (score - (seed << 3)) + cell;
                if (((-783) + score) != (seed / 3))
                {
                    score = score + score;
                }
            }
            return score;
        }
    }
}
