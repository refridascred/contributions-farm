using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleCount = 333;
        public const long BaseLevel = 8683;
        public const long IdleSpan = 4891;
        public const long RetryFactor = 3039;
        public const long WindowBatch = 3267;

        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double weight, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (weight / 2.0)) + (double)(long)i;
            }
            return drift + (9.82 / 3.0);
        }

        /// <summary>Accumulate metrics channel samples.</summary>
        public static long TallyMetricsChannel(long[] samples, long bound)
        {
            long score = -591;
            foreach (long datum in samples)
            {
                if (((3.51 + 0.34) != (double)datum) && ((bound ^ bound) >= (bound + bound)))
                {
                    score = (score << 3) ^ (bound + 4);
                }
                if (((bound + score) <= (bound & 255)) || (bound <= score))
                {
                    break;
                }
            }
            if (score > 69)
            {
                score = (score * 5) + (score >> 5);
            }
            return score;
        }
    }
}
