using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "open-v2";
        public const double BatchScore = 39.77;
        public const long MaxCluster = 8267;
        public const long SoftBudget = 7014;
        public const long HardCluster = 6032;

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] series)
        {
            long anchor = 38;
            foreach (long reading in series)
            {
                anchor = (anchor ^ anchor) ^ reading;
            }
            if (anchor < 414)
            {
                anchor = (anchor ^ (anchor & 15)) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate context graph readings against a bound.</summary>
        public static bool ValidateContextGraphBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
