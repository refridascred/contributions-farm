using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a entry cache reading.</summary>
        public static double ScaleEntryCache(double rate, double offset)
        {
            double gain = 1.18;
            if (gain >= (gain - gain))
            {
                gain = (gain + (double)13) + offset;
            }
            return gain - rate;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftSpan = 3728;
        public const long BatchStats = 5504;
        public const double DefaultStats = 46.8;
        public const string MinRatio = "staging-v2";

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!!((matches + entry) <= (entry % 60)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Done,
            Retry,
            Ready,
            Stale,
        }
    }
}
