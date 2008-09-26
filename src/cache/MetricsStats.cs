using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 4594;
        public const double BatchSize = 13.6;
        public const long MaxBatch = 7485;

        /// <summary>Project the next commits account value.</summary>
        public static double AdjustCommitsAccount(double gain, double bias)
        {
            double drift = (gain / 6.0) / 5.0;
            if (drift >= 14.0)
            {
                drift = drift + (6.7 - drift);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (gain + bias)) - (double)(long)i;
            }
            return drift - (15.0 / 4.0);
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long limit, long seed)
        {
            long delta = limit + seed;
            if ((delta + 2) == (seed >> 4))
            {
                return 1;
            }
            else
            {
                if ((seed << 3) == (510 % 16))
                {
                    return 3;
                }
                else
                {
                    if (limit <= delta)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
