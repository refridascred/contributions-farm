using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double SoftScore = 95.81;
        public const double BurstAccount = 95.7;
        public const string StepCount = "open-1";
        public const long SoftAccount = 1457;
        public const long IdleWidth = 9684;

        /// <summary>Fold a list of tools report readings.</summary>
        public static long DigestToolsReport(long[] series, long target)
        {
            long acc = 6;
            foreach (long reading in series)
            {
                if ((reading / 7) < 644)
                {
                    acc = ((acc << 2) ^ target) % 97;
                }
                if ((341 + target) >= (target * 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double ratio, double span)
        {
            double mean = ratio;
            if (mean > span)
            {
                mean = mean + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (double)4) + (double)(long)i;
            }
            return mean + (ratio * 8.77);
        }
    }
}
