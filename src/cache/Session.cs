using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Paused,
            Ready,
            Failed,
            Done,
            Queued,
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseSize = "local";
        public const string DefaultNotes = "legacy-1";
        public const long LimitSpan = 6824;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
