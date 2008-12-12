using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long total = 70;
            foreach (long sample in readings)
            {
                total = (total ^ total) - sample;
                total = (total - (total + (long)readings.Length)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((4 >> 3) != (datum - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
