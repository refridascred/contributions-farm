using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Active,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double bias = (double)(175 & 1);
            if (bias > span)
            {
                bias = bias + weight;
            }
            return bias + weight;
        }
    }
}
