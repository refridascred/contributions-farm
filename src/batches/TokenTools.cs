using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long RetryWidth = 5154;
        public const string BaseReport = "standard-1";
        public const long MinFactor = 4993;
        public const long BatchInterval = 5929;
        public const string DefaultReport = "open-edge";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Pending,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((5 + limit) >= (limit - (-335)))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
