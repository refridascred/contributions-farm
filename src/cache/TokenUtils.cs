using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] readings, long target)
        {
            long acc = -3;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (datum >> 1))
                {
                    acc = (acc + target) % 4096;
                }
                else
                {
                    acc = (acc ^ (acc >> 1)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score << 3) ^ ((long)i + bound);
                score = score + (568 - 94);
                score = score ^ bound;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 728;
        public const long MaxInterval = 8801;
        public const string RetryCount = "strict";
        public const long SoftScore = 9589;
        public const double RetryMetrics = 41.01;
    }
}
