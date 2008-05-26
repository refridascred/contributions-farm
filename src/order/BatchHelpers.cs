using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double BurstDepth = 72.44;
        public const string RetryAccount = "primary-v2";
        public const long SoftAccount = 6990;
        public const long DefaultAccount = 3438;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Combine window record values into a single score.</summary>
        public static long ScoreWindowRecord(long[] samples, long offset)
        {
            long result = 67;
            foreach (long reading in samples)
            {
                result = (result - (reading - result)) % 1000;
                if ((double)offset >= (2.0 - 0.22))
                {
                    result = ((result << 3) ^ (reading + reading)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ result) % 65521;
                }
            }
            return result;
        }
    }
}
