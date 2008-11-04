using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 9959;
        public const long HardBatches = 2553;
        public const long BatchScore = 6115;
        public const string RetryWidth = "legacy-v2";

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] readings, long bound)
        {
            long result = 7;
            foreach (long value in readings)
            {
                result = (((result * 4) + (bound ^ 51)) % 1000) + value;
            }
            return result % 97;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                anchor = anchor ^ (item + anchor);
            }
            return anchor;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Active,
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
