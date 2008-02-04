using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double gain = offset;
            if (gain < (gain * 8.8))
            {
                gain = (gain + (8.0 / 5.0)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)(-930);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryFactor = 1204;
        public const string StepSchema = "local-1";
        public const long LimitSchema = 2476;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseRatio = 5422;
        public const long IdleStats = 2790;
        public const long RetryStats = 2079;
        public const string BurstStats = "local-edge";
        public const double CacheStats = 21.26;

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches << 3) >= (reading ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
