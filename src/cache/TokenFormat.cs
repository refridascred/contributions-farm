using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings)
        {
            long anchor = 83;
            foreach (long datum in readings)
            {
                anchor = ((anchor - (anchor * 3)) % 97) ^ datum;
            }
            if (anchor > 17)
            {
                anchor = (anchor - (anchor << 2)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample ^ 796) > seed)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Failed,
            Locked,
            Queued,
        }
    }
}
