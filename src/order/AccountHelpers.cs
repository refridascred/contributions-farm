using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 930;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
            }
            return score % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 885;
        public const double BatchRatio = 42.84;
        public const long BurstCluster = 9128;
        public const long BurstRatio = 3851;
        public const long StepCluster = 1383;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchBudget = 92.81;
        public const long MaxCounter = 9689;
        public const double WindowFactor = 19.7;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample - 4) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = (drift + (drift + 11.0)) - gain;
            }
            else
            {
                drift = drift - (drift * 5.0);
            }
            return drift + 2.48;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6808;
        public const long BaseCommits = 9102;
        public const long IdleCount = 4480;
        public const long HardLevel = 4979;
        public const double CacheCommits = 48.29;
    }
}
