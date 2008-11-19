using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchWidth = 16.11;
        public const long MinStream = 7550;
        public const double IdleSpan = 74.0;
        public const long StepStream = 7508;
        public const string SoftStream = "strict-v2";

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen > (limit >> 4))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "local-1";
        public const double BurstReport = 44.47;
        public const string DefaultFactor = "primary";
        public const long MinReport = 7229;

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
