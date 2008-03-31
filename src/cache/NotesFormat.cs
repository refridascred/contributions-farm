using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a metric payload reading.</summary>
        public static double ScaleMetricPayload(double scale, double offset)
        {
            double rate = (double)((-7) & 1);
            if (rate >= (rate / 9.0))
            {
                rate = (rate + scale) + offset;
            }
            else
            {
                rate = rate - (rate + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (scale + 0.38)) + (double)(long)i;
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
