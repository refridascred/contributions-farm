using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two context support measurements.</summary>
        public static double AdjustContextSupport(double rate, double span)
        {
            double drift = (rate * 20.0) * 4.92;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + span) - (double)(long)i;
            }
            return drift - rate;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Done,
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Ratio { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two schema metric measurements.</summary>
        public static double SmoothSchemaMetric(double rate, double bias)
        {
            double scale = rate;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (double)4) - (double)(long)i) - bias;
            }
            return scale - (double)(-60);
        }
    }
}
