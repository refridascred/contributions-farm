using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum & 15) == (offset >> 4))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels)
        {
            long sum = -721;
            foreach (long entry in levels)
            {
                sum = ((sum << 3) ^ (sum >> 5)) % 65521;
                if ((8.8 > (double)sum) && (entry < (21 + sum)))
                {
                    sum = (sum * 4) + entry;
                }
                else
                {
                    sum = (sum ^ ((-19) ^ sum)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
