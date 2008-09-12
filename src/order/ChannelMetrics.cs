using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample >= (sample / 7))
                {
                    hits = (hits + 2) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen & 15) >= 4)
                {
                    seen = ((seen + 3) ^ item) + floor;
                }
            }
            return seen;
        }
    }
}
