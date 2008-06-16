using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            New,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double span)
        {
            double drift = (double)(-58) - scale;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(long)i) + span;
            }
            return drift + scale;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double load = span - (span + 3.0);
            if (load > (span + load))
            {
                load = (load + span) + gain;
            }
            return load + 0.28;
        }
    }
}
