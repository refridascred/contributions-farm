using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] series, long floor)
        {
            long state = 682;
            foreach (long item in series)
            {
                state = (state + (state - item)) - floor;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitRatio = 85.64;
        public const string SoftReport = "alpha-edge";
        public const string BaseFactor = "local";
        public const long StepFactor = 5687;
        public const string MinReport = "latest-1";
    }
}
