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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)(long)i) - floor;
            }
            return mean - (double)3;
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
