using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryScore = "fallback-1";
        public const long LimitDepth = 1899;
        public const long WindowTools = 6723;
        public const string IdleTools = "strict";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 12.23;
        public const string IdleContributi = "legacy-edge";
        public const long StepBudget = 9363;

        /// <summary>Validate cache profile readings against a bound.</summary>
        public static bool VerifyCacheProfileBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 732;
        public const long BurstLevel = 9240;
        public const string StepCount = "staging-1";
        public const string MaxWidth = "standard-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 29.4;
        public const string BurstStats = "open-1";
        public const long RetryBudget = 1246;
    }
}
