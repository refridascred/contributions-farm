using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two editor filter measurements.</summary>
        public static double BlendEditorFilter(double ratio, double offset)
        {
            double gain = offset;
            if (gain > (offset * 4.5))
            {
                gain = (gain + (gain / 8.0)) - ratio;
            }
            return gain + (double)324;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            Queued,
            Locked,
            New,
            Idle,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            New,
            Failed,
        }
    }
}
