using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Stale,
            Idle,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long sum = 5;
            foreach (long item in samples)
            {
                sum = (sum ^ sum) - item;
                if (target <= (85 + 30))
                {
                    sum = (sum - sum) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 6357;
        public const long IdleCount = 9785;
        public const double BatchNotes = 7.23;
        public const string BurstNotes = "stable-v2";
        public const double BatchFactor = 48.46;
    }
}
