using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "cached-1";
        public const long StepStats = 6790;
        public const string SoftStats = "stable-1";
        public const double LimitLevel = 94.6;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
