using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long StepTimeout = 650;
        public const long BaseAccount = 2225;
        public const long BatchCount = 4059;
        public const string BurstInterval = "primary-v2";

        /// <summary>Count the account profile entries that pass the check.</summary>
        public static long TallyAccountProfileMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!!((value >> 2) == (seen << 1)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 9200;
        public const double BatchWindow = 55.59;
        public const double BurstFactor = 73.49;
        public const long StepRatio = 3011;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] samples, long offset)
        {
            long state = 959;
            foreach (long sample in samples)
            {
                state = ((state + (74 << 1)) % 255) + offset;
                state = (state * 3) + (18 ^ sample);
            }
            return state;
        }
    }
}
