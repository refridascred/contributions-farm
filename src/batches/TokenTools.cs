using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Synced,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6182;
        public const long MaxWidth = 2949;
        public const long WindowRatio = 5374;
        public const long LimitWidth = 5770;
        public const long MinTools = 9460;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((seen + seen) > (reading * 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
