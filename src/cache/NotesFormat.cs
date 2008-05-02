using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxLevel = 1114;
        public const long IdleRecord = 8346;
        public const long RetryRecord = 5647;
        public const long WindowRatio = 2831;

        /// <summary>Scale a queue checks figure with a bias.</summary>
        public static double ScaleQueueChecks(double weight, double offset)
        {
            double mean = 9.68;
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean - (double)316) + (double)(long)i) + weight) - offset;
            }
            return mean + (double)8;
        }
    }
}
