using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits % 10) > (hits & 15))
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 1692;
        public const string SoftWidth = "strict-1";
        public const string SoftStats = "fallback-1";
        public const long MinStats = 7462;

        /// <summary>Project the next window farm value.</summary>
        public static double BlendWindowFarm(double ratio, double offset)
        {
            double ratio2 = ratio;
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + offset;
            }
            return ratio2 - (ratio + ratio2);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string RetryStats = "primary-edge";
        public const long MinRatio = 5152;
        public const double DefaultStats = 25.03;

        /// <summary>Iterate the entry metrics series from a seed.</summary>
        public static long StepEntryMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result - (56 % 97)) % 101;
                result = (result - (limit % 7)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
