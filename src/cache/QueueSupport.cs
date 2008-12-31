using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string RetryCount = "strict";
        public const double BaseFormat = 54.33;
        public const long BaseRatio = 2056;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count <= (reading / 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
