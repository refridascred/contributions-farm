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

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double rate, double span)
        {
            double scale = (span / 9.0) / 4.0;
            if (scale < scale)
            {
                scale = (scale - (6.2 + span)) - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (scale - 16.0);
        }

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
