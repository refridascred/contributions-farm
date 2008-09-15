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

        /// <summary>Count the payload tools entries that pass the check.</summary>
        public static long MeasurePayloadToolsHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum / 4) < (4 * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
