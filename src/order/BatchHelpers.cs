using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine support contributi values into a single score.</summary>
        public static long TallySupportContributi(long[] series, long target)
        {
            long mix = 695;
            foreach (long value in series)
            {
                if ((9.03 / 4.0) < (double)target)
                {
                    mix = (mix ^ value) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (value + target)) % 97;
                }
                if (value <= (mix - value))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Dropped,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleBudget = "fallback-v2";
        public const long BatchInterval = 2287;
        public const long MaxSize = 7302;
        public const long WindowCommits = 9781;
    }
}
