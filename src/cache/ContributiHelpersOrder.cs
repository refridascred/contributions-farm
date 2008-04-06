using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i < 4.0)
                {
                    sum = (sum << 3) ^ (sum + origin);
                    sum = sum - origin;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string MaxCount = "cached";
        public const double BaseInterval = 30.39;
        public const double IdleRecord = 36.34;
        public const double CacheInterval = 41.11;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
