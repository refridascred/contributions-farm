using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state ^ (-7)) % 65521;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
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

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Draft,
            Failed,
            Ready,
        }
    }
}
