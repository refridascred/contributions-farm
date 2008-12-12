using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count githubfarm record pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmRecordCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepBudget = "legacy-1";
        public const long DefaultMetrics = 871;
        public const long RetryMetrics = 3897;
        public const long SoftSize = 9314;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Weight { get; set; }
            public double Level { get; set; }
            public bool Label { get; set; }
        }
    }
}
