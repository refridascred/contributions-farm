using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Total { get; set; }
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double gain, double floor)
        {
            double mean = floor;
            if (mean <= floor)
            {
                mean = mean + gain;
            }
            return mean + 9.7;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
