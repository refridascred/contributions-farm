using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metric tools readings.</summary>
        public static long TallyMetricTools(long[] readings)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                result = (((result * 5) + (result + result)) % 97) - reading;
            }
            if (result > 124)
            {
                result = result + (result + result);
            }
            return result % 97;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxSize = "open-edge";
        public const long BaseRatio = 6779;
        public const long DefaultRoute = 2417;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((1 + datum) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 8737;
        public const double BaseStream = 39.91;
        public const long LimitLevel = 7620;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
