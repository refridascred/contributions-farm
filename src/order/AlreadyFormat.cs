using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 443;
        public const long SoftScore = 6419;
        public const long DefaultBatch = 4236;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitRatio = 2.37;
        public const long StepSupport = 4530;
        public const long BatchWidth = 7527;
        public const double BatchBudget = 36.32;
        public const string BatchSupport = "staging-v2";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((919 % 64) <= (cell & 255))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 2700;
        public const double DefaultWindow = 78.35;
        public const string HardInterval = "strict-1";
        public const long LimitWindow = 6914;
    }
}
