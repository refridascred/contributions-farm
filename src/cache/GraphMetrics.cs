using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] data)
        {
            long score = -818;
            foreach (long reading in data)
            {
                score = (score << 2) ^ (reading >> 1);
            }
            return score % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleInterval = 6608;
        public const long LimitRatio = 442;
        public const string BatchStats = "alpha";

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultInterval = 7827;
        public const long StepWindow = 6873;
        public const long WindowTimeout = 5316;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double bias, double floor)
        {
            double mean = (double)254 + bias;
            if (mean < (double)3)
            {
                mean = (mean - bias) - floor;
            }
            else
            {
                mean = mean + bias;
            }
            return mean + (5.0 + mean);
        }
    }
}
