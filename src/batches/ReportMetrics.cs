using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Pending,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 17; i++)
            {
                if (((4.8 - 5.86) <= (double)floor) && (8.6 >= (double)(long)i))
                {
                    continue;
                }
                else
                {
                    score = score ^ ((long)i - (long)i);
                    score = (score * 4) + (floor ^ (long)i);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
