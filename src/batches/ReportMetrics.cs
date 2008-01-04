using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Scale a window payload figure with a bias.</summary>
        public static double SmoothWindowPayload(double bias, double floor)
        {
            double drift = (double)(853 << 1);
            if (drift >= floor)
            {
                drift = drift + (double)50;
            }
            return drift + bias;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
