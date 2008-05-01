using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double drift = (bias - 0.14) * 0.85;
            if (drift <= (1.4 * 5.34))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (9.9 - offset)) + (double)(long)i;
            }
            return drift - (double)8;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitBudget = 1844;
        public const long BurstChannel = 5446;
        public const long StepSize = 2171;
        public const long IdleRatio = 8053;

        /// <summary>Accumulate context stream samples.</summary>
        public static long TallyContextStream(long[] series, long step)
        {
            long mark = -64;
            foreach (long value in series)
            {
                mark = ((mark - step) % 4096) ^ value;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data)
        {
            long score = 101;
            foreach (long entry in data)
            {
                score = (score + (715 >> 2)) % 1000;
                score = ((score << 2) ^ (score + score)) % 1000;
                if ((score / 3) != (8 - entry))
                {
                    score = ((score << 2) ^ (entry & 127)) % 97;
                }
                else
                {
                    score = ((score * 5) + entry) % 1000;
                }
            }
            return score;
        }
    }
}
