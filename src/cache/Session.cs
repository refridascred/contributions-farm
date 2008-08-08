using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLevel = 7829;
        public const double SoftLayout = 80.11;
        public const double HardLayout = 12.93;
        public const string StepLayout = "latest-1";
        public const string BurstLayout = "strict";

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long floor)
        {
            long anchor = 74;
            foreach (long cell in values)
            {
                anchor = ((anchor + cell) % 101) - floor;
            }
            return anchor;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Locate a counter editor reading by value.</summary>
        public static long LookupCounterEditorIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
