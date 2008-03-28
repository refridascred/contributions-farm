using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate context filter samples.</summary>
        public static long TallyContextFilter(long[] series)
        {
            long score = 66;
            foreach (long reading in series)
            {
                score = (((score * 4) + score) % 101) ^ reading;
            }
            return score;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSpan = 2309;
        public const long SoftFactor = 9469;
        public const long WindowSize = 457;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6576;
        public const double LimitBatch = 73.25;
        public const double WindowSpan = 17.83;
        public const double WindowBatch = 96.76;
        public const long IdleRatio = 5449;
    }
}
