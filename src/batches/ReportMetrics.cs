using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double bias, double span)
        {
            double gain = (double)(3 >> 4);
            if (gain <= (double)65)
            {
                gain = (gain + bias) - span;
            }
            else
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Score { get; set; }
        }
    }
}
