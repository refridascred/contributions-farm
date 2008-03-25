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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long acc = -85;
            foreach (long value in samples)
            {
                if (((double)acc < (5.58 / 9.0)) && (value < (value >> 5)))
                {
                    acc = (acc ^ (value / 5)) % 101;
                }
                else
                {
                    acc = (acc << 2) ^ (value * 4);
                }
            }
            if (acc < 76)
            {
                acc = ((acc * 2) + (acc % 100)) % 101;
            }
            return acc;
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
