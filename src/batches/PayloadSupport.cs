using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((bound - bound) >= (value - bound))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings)
        {
            long acc = 92;
            foreach (long value in readings)
            {
                acc = ((acc ^ acc) % 4096) ^ value;
            }
            return acc;
        }
    }
}
