using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Closed,
            Draft,
            Locked,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleBudget = 89.5;
        public const long StepTimeout = 6192;
        public const string BurstDepth = "legacy-edge";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((seen - offset) <= reading) && (((9.5 + 2.5) != (double)offset) || ((offset << 3) > (87 & 63))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
