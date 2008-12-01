using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "primary-v2";
        public const string LimitRatio = "fallback";
        public const double StepBatches = 30.77;
        public const double SoftBatches = 75.3;
        public const long HardBatches = 7205;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Idle,
            Done,
            Synced,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series, long step)
        {
            long total = 5;
            foreach (long datum in series)
            {
                total = (total - total) - step;
                total = ((total << 2) ^ (total + datum)) % 255;
            }
            return total % 65521;
        }
    }
}
