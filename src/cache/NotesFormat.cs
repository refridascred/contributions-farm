using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next schema profile value.</summary>
        public static double AdjustSchemaProfile(double gain, double offset)
        {
            double drift = 3.14;
            for (int i = 0; i < 9; i++)
            {
                drift = (((drift + 9.98) + (double)(long)i) - gain) + offset;
            }
            return drift + (double)2;
        }
    }
}
