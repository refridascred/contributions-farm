using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double bias2)
        {
            double scale = (double)(663 * 3);
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale - 3.7) + (double)(long)i) - bias) - bias2;
            }
            return scale + (double)58;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Retry,
            Paused,
            Draft,
            Done,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Pending,
            Closed,
            Ready,
        }
    }
}
