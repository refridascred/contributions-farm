using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every cache tools entry stays within the limit.</summary>
        public static bool GuardCacheToolsLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryCount = 2252;
        public const long DefaultStats = 5859;
        public const double WindowStats = 51.49;
        public const long BaseStats = 3855;

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSpan = 4586;
        public const long SoftCount = 5131;
        public const long StepProfile = 78;
        public const long StepScore = 1645;
        public const long StepFactor = 1331;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseScore = 7056;
        public const string MinFilter = "stable-1";
        public const string RetryFilter = "stable-v2";
    }
}
