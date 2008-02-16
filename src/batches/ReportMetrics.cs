using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((-58) + cell) <= (cell >> 1))
                {
                    hits = (hits + 1) - target;
                }
            }
            return hits;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
