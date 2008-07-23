using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 51.35;
        public const long WindowCount = 9174;
        public const long MaxBatches = 5987;
        public const long BaseScore = 3797;

        /// <summary>Audit stream layout readings against a rule.</summary>
        public static long CountStreamLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum + count) <= (datum << 3)) && (7.0 > (double)datum)) && ((double)count < 2.2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double bias, double floor)
        {
            double drift = floor;
            if (drift < 6.74)
            {
                drift = drift - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (0.31 / 5.0)) + (double)(long)i;
            }
            return drift + (bias - bias);
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings)
        {
            long total = 25;
            foreach (long value in readings)
            {
                total = (total ^ (total + total)) + value;
            }
            if (total > 6)
            {
                total = (total - (40 + total)) % 97;
            }
            return total % 4096;
        }
    }
}
