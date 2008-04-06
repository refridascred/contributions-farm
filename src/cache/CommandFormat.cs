using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] samples, long target)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry < (count ^ 655)))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheDepth = 3779;
        public const double StepChecks = 84.22;
        public const string MaxTimeout = "primary-v2";
        public const long MaxChecks = 221;
        public const long MinChecks = 3356;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Paused,
            Dropped,
            Done,
        }
    }
}
