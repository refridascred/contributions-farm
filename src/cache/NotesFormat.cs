using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double weight = 6.88;
            if (weight > 1.91)
            {
                weight = (weight + (bias - weight)) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - 6.0) + (double)(long)i;
            }
            return weight + (double)(-2);
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
