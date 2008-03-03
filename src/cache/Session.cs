using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue already readings.</summary>
        public static long WeighQueueAlready(long[] series)
        {
            long state = -69;
            foreach (long reading in series)
            {
                if ((state + state) == (reading * 2))
                {
                    state = state + (long)series.Length;
                }
            }
            return state;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample <= 8.86)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
