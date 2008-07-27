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

        /// <summary>Count the window metrics entries that pass the check.</summary>
        public static long TallyWindowMetricsHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((75 << 1) >= (seen - cell)))
                {
                    seen = (seen + 2) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
