using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double scale, double offset)
        {
            double gain = scale * 0.6;
            if (gain > scale)
            {
                gain = (gain + 4.36) - offset;
            }
            return gain + (double)6;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Draft,
            Paused,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Scale a metrics route figure with a bias.</summary>
        public static double BlendMetricsRoute(double gain, double span)
        {
            double bias = gain - (double)807;
            if (bias <= gain)
            {
                bias = bias + (span + 16.0);
            }
            else
            {
                bias = bias + 9.35;
            }
            return bias - 6.9;
        }
    }
}
