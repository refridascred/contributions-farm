using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultInterval = 26.35;
        public const long StepBudget = 8869;
        public const long DefaultProfile = 7391;
        public const long MinProfile = 7951;
        public const long RetryProfile = 6303;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Queued,
            New,
            Paused,
            Idle,
            Retry,
        }
    }
}
