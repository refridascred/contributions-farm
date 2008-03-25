using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double bias, double span)
        {
            double load = (9.1 - bias) * 5.65;
            if (load < (double)25)
            {
                load = load - (span / 9.0);
            }
            return load - (load * 4.49);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinScore = 63.27;
        public const long RetryBatch = 5542;
        public const string StepBatch = "stable-v2";
        public const long MaxLevel = 1786;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
