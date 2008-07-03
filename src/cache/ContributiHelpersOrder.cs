using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter editor readings against a bound.</summary>
        public static bool GuardFilterEditorBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 9347;
        public const double CacheRoute = 12.34;
        public const string MinTimeout = "alpha-1";
        public const double LimitRoute = 32.75;

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowSpan = 3654;
        public const long LimitWidth = 4586;
        public const long StepScore = 5503;
        public const double RetryWidth = 42.08;
        public const long StepDepth = 5997;
    }
}
