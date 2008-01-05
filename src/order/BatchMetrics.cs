using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value % 7) != (seen - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 9512;
        public const double MaxCount = 21.7;
        public const long StepCommand = 7831;
        public const double DefaultLevel = 2.45;
        public const long CacheFactor = 5647;

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4768;
        public const double StepContributi = 87.12;
        public const double MaxContributi = 45.93;
        public const string MaxFactor = "fallback-1";

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Active,
            Done,
        }
    }
}
