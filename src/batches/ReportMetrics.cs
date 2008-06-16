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

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double ratio, double bias)
        {
            double rate = (double)(9 + 3);
            if (rate <= (double)66)
            {
                rate = (rate + (19.0 + ratio)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)204) + (double)(long)i;
            }
            return rate + rate;
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
