using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double span)
        {
            double drift = span;
            if (drift < (drift * 5.37))
            {
                drift = drift - (double)770;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (scale - drift)) - (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a checks schema reading.</summary>
        public static double BlendChecksSchema(double scale, double floor)
        {
            double gain = (2.0 - 8.3) * 12.0;
            if (gain > (double)63)
            {
                gain = (gain + (gain / 3.0)) + floor;
            }
            else
            {
                gain = gain + (scale / 8.0);
            }
            return gain + scale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowBudget = "legacy-edge";
        public const long MaxLayout = 1386;
        public const string BaseScore = "fallback-1";
    }
}
