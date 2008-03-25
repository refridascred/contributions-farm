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

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long DigestBatchesEditor(long[] levels, long floor)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                if ((6.5 + 0.3) < (double)entry)
                {
                    score = (score ^ (floor + floor)) % 97;
                }
            }
            return score;
        }
    }
}
