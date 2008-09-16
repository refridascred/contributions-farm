using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen % 12) > sample)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
