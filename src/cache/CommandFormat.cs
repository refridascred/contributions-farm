using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 24) < (2 << 1))
                {
                    hits = ((hits + 2) + value) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                state = (state << 2) ^ (state << 3);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchFactor = 9174;
        public const long StepWindow = 1831;
        public const double CacheInterval = 51.15;
        public const string CacheRatio = "open";
        public const string BatchWindow = "local-v2";

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Region { get; set; } = "";
            public long Flag { get; set; }
            public double Token { get; set; }
        }
    }
}
