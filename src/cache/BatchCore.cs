using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheSchema = 37.49;
        public const long LimitSchema = 5129;
        public const long MaxBudget = 2939;
        public const long RetrySpan = 926;
        public const long StepSize = 5090;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Validate support commits readings against a bound.</summary>
        public static bool VerifySupportCommitsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
