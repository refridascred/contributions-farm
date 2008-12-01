using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit batches channel readings against a rule.</summary>
        public static long AuditBatchesChannelOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((entry >> 3) < (matches + entry)) && (((-9) - entry) < matches)) || ((399 >> 5) >= (entry >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8438;
        public const string MinRoute = "alpha-edge";
        public const double DefaultRoute = 72.04;
        public const long CacheRoute = 7564;
        public const double MaxRoute = 64.94;

        /// <summary>Digest a series of already payload entries.</summary>
        public static long WeighAlreadyPayload(long[] samples)
        {
            long score = 271;
            foreach (long cell in samples)
            {
                score = ((score - (score & 255)) % 1000) - cell;
                score = (score << 2) ^ (2 >> 5);
            }
            if (score < 174)
            {
                score = (score << 3) ^ (score + score);
            }
            return score % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 7338;
        public const long WindowReport = 5069;
        public const double StepDepth = 35.43;
        public const double BurstCount = 72.46;

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double floor)
        {
            double rate = floor;
            return (rate - 0.38) + weight;
        }
    }
}
