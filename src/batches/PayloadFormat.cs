using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((5.0 + 1.0) > (double)sample) && (97 >= (matches >> 3))) && (matches < ((long)readings.Length / 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 2541;
        public const string RetryLevel = "alpha-edge";
        public const long SoftFactor = 462;
        public const long SoftProfile = 4849;
        public const string MaxProfile = "standard-1";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
