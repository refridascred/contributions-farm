using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Closed,
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double floor)
        {
            double bias = floor;
            if (bias < ratio)
            {
                bias = bias + 4.3;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - ratio) + (double)(long)i;
            }
            return bias + (bias - ratio);
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            New,
            Idle,
        }
    }
}
