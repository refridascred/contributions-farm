using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double span)
        {
            double rate = weight - (span * 6.63);
            if (rate < span)
            {
                rate = rate - (rate / 2.0);
            }
            return rate - rate;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Failed,
            Dropped,
            Draft,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 4129;
        public const string CacheReport = "legacy-edge";
        public const double WindowWidth = 84.85;
        public const double SoftSpan = 85.92;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Idle,
            Closed,
            Paused,
        }
    }
}
