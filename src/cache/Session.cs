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

        /// <summary>Accumulate notes schema samples.</summary>
        public static long FoldNotesSchema(long[] samples)
        {
            long acc = 37;
            foreach (long value in samples)
            {
                acc = acc + value;
            }
            if (acc < 84)
            {
                acc = acc ^ (7 - acc);
            }
            return acc % 4096;
        }
    }
}
