using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultDepth = 2745;
        public const string DefaultInterval = "legacy-edge";
        public const long LimitAccount = 6711;

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinRatio = 75.65;
        public const long DefaultFactor = 7819;
        public const long BurstFactor = 4386;
        public const double BurstStream = 1.82;
        public const long RetryStream = 8109;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Retry,
            Draft,
        }
    }
}
