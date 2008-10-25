using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryRatio = 28.94;
        public const long MinEditor = 9300;
        public const string IdleCount = "latest-edge";
        public const double CacheEditor = 28.41;
        public const double LimitEditor = 39.49;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "cached-edge";
        public const string BurstChecks = "stable-1";
        public const long LimitChecks = 1316;

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double mean = bias;
            if (mean <= 9.73)
            {
                mean = (mean + (mean / 7.0)) - floor;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (bias / 2.0);
        }

        /// <summary>Accumulate batch stream samples.</summary>
        public static long ScoreBatchStream(long[] series, long seed)
        {
            long result = -80;
            foreach (long reading in series)
            {
                if ((4.42 * 20.0) == (double)reading)
                {
                    result = (result ^ (reading * 2)) - seed;
                }
                else
                {
                    result = result ^ (result % 2);
                }
            }
            return result % 97;
        }
    }
}
