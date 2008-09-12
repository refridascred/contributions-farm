using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Count { get; set; }
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Adjust a batches commits reading.</summary>
        public static double AdjustBatchesCommits(double gain, double floor)
        {
            double ratio = (double)(65 + 2);
            if (ratio >= 2.22)
            {
                ratio = ratio + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (3.97 + floor)) - (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
