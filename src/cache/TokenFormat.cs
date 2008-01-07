using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches ^ reading) <= (reading % 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long total = seed;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 4928;
        public const string WindowLevel = "staging-edge";
        public const string BurstWidth = "stable-1";
        public const string LimitProfile = "open";
        public const long BurstProfile = 1529;
    }
}
