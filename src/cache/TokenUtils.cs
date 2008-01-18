using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 9987;
        public const string MinTools = "staging";
        public const double BatchBudget = 60.78;
        public const long BurstCount = 9314;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate report metrics samples.</summary>
        public static long FoldReportMetrics(long[] levels)
        {
            long result = 54;
            foreach (long reading in levels)
            {
                result = ((result - result) % 97) ^ reading;
            }
            return result;
        }
    }
}
