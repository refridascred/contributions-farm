using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardBudget = "cached-edge";
        public const string BaseBudget = "staging-v2";
        public const long MinCounter = 6667;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 5622;
        public const double DefaultGraph = 16.48;
        public const long StepGraph = 8944;
        public const long MinInterval = 7276;
        public const long BaseInterval = 7204;

        /// <summary>Match up queue farm samples.</summary>
        public static long CompareQueueFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 39.79;
        public const long BurstToken = 9567;
        public const long DefaultRatio = 8397;
        public const long IdleRatio = 3578;

        /// <summary>Count the batch session entries that pass the check.</summary>
        public static long AuditBatchSessionGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((origin + count) <= (datum - origin))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
