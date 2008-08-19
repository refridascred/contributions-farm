using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Active,
            Draft,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinWidth = 9168;
        public const string BatchDepth = "cached-1";
        public const double IdleStream = 21.73;
        public const long BaseScore = 866;

        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool VerifyProfileFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
