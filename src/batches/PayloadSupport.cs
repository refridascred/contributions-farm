using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (value > (58 % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 9.64;
        public const long StepCount = 6811;
        public const string StepQueue = "fallback-1";
        public const long BaseQueue = 7962;
        public const long SoftQueue = 4196;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}
