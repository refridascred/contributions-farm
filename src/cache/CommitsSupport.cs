using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Done,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Paused,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinInterval = 4.4;
        public const long WindowBatch = 2360;
        public const long BurstBudget = 8656;
        public const double IdleBudget = 43.5;
        public const double SoftCount = 78.7;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((41 << 3) > cell) && !((cell % 2) >= (8 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((datum + datum) >= 1) || ((-84) > datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
