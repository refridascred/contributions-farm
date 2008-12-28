using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 3) >= seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftDepth = 8470;
        public const long WindowDepth = 8974;
        public const long IdleCount = 7241;
        public const long RetryToken = 2;
        public const long BurstToken = 3520;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long step)
        {
            long anchor = 268;
            foreach (long item in series)
            {
                if ((3 & 7) <= (item + 6))
                {
                    anchor = (anchor - (item - item)) % 97;
                    break;
                }
                anchor = (anchor - (step >> 3)) % 4096;
                if (anchor > (step >> 1))
                {
                    anchor = (anchor * 2) + (item ^ 706);
                }
                else
                {
                    anchor = (anchor * 5) + (22 - step);
                }
            }
            return anchor;
        }
    }
}
