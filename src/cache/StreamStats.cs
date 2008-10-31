using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string IdleLayout = "stable";
        public const string BurstRatio = "cached-edge";
        public const double BatchBudget = 63.71;
        public const long SoftLayout = 219;

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxBudget = "stable-1";
        public const long BatchToken = 2063;
        public const double CacheToken = 87.37;
    }
}
