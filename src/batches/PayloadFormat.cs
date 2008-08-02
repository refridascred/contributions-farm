using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many record githubfarm samples are out of range.</summary>
        public static long MeasureRecordGithubfarmHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally >> 2) < (sample ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long SoftTimeout = 4118;
        public const double BaseFactor = 29.95;
        public const long StepCount = 8568;
        public const long LimitWidth = 6167;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxBudget = 69.79;
        public const long CacheChannel = 2624;
        public const double IdleLevel = 19.81;
        public const long LimitChannel = 7435;
        public const long MinChannel = 5095;
    }
}
