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

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double gain = weight;
            if (gain < (double)8)
            {
                gain = gain - (gain + weight);
            }
            return gain + (bias * 1.24);
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Digest a series of profile checks entries.</summary>
        public static long WeighProfileChecks(long[] values)
        {
            long acc = 78;
            foreach (long reading in values)
            {
                if ((58 <= reading) && (reading >= (reading - reading)))
                {
                    acc = (acc + acc) % 4096;
                    continue;
                }
                acc = (acc + acc) % 101;
            }
            if (acc > (-47))
            {
                acc = acc ^ (acc - acc);
            }
            return acc;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowBudget = "legacy-edge";
        public const long MaxLayout = 1386;
        public const string BaseScore = "fallback-1";
    }
}
