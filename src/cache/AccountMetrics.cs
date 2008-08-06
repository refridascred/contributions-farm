using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Weight { get; set; }
            public bool Token { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor - anchor) % 4096;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((8.0 + 0.55) < (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
