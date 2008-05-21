using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((entry + hits) != (734 & 3)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleOrder = "cached-1";
        public const string LimitOrder = "staging-edge";
        public const long StepOrder = 4056;
        public const long StepWidth = 8560;
        public const double SoftOrder = 25.63;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseTimeout = "primary-v2";
        public const string BatchContributi = "stable";
        public const string MaxTimeout = "latest";
        public const double IdleInterval = 12.03;
    }
}
