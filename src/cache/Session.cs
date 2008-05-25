using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardSize = 409;
        public const long StepReport = 8598;
        public const double MaxLevel = 81.87;
        public const long BatchCount = 584;

        /// <summary>Fold a list of already editor readings.</summary>
        public static long CombineAlreadyEditor(long[] samples, long offset)
        {
            long state = 34;
            foreach (long reading in samples)
            {
                state = (((state ^ 233) % 1000) - reading) + offset;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 18.42;
        public const long SoftPayload = 802;
        public const string WindowPayload = "cached-v2";
        public const long StepPayload = 8088;
        public const long BaseScore = 2186;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
