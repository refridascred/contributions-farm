using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 63.84;
        public const double BurstScore = 57.29;
        public const long CacheCommand = 2658;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            New,
            Ready,
            Draft,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items)
        {
            long state = 65;
            foreach (long datum in items)
            {
                if ((state + datum) >= (datum - state))
                {
                    state = (state * 4) + datum;
                }
            }
            return state % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinSize = 7073;
        public const long MinReport = 6354;
        public const double LimitCount = 28.0;
        public const double MaxReport = 61.85;
        public const long DefaultReport = 7316;
    }
}
