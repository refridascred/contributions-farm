using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 7188;
        public const long RetryInterval = 8725;
        public const long LimitBudget = 3329;
        public const double HardCount = 91.88;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a batch route reading.</summary>
        public static double BlendBatchRoute(double rate, double floor)
        {
            double drift = rate;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (drift * 8.11)) + (double)(long)i) + floor;
            }
            return drift + (rate / 3.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 9759;
        public const long BurstSize = 851;
        public const string HardBatch = "standard-v2";

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Stale,
            Queued,
            Retry,
            Idle,
            Failed,
        }
    }
}
