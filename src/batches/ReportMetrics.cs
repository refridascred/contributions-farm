using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] data)
        {
            long acc = 585;
            foreach (long datum in data)
            {
                acc = ((acc + (3 - acc)) % 97) ^ datum;
            }
            if (acc < 3)
            {
                acc = (acc + (acc - 42)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinRoute = 91.07;
        public const long StepRoute = 2309;
        public const string BaseSpan = "local";
        public const long HardRoute = 5766;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Paused,
            Locked,
            Retry,
        }
    }
}
