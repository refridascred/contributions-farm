using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 50.93;
        public const long WindowTools = 267;
        public const long LimitDepth = 827;
        public const double IdleTools = 56.25;
        public const double LimitInterval = 92.4;

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Closed,
            Ready,
            Active,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double bias)
        {
            double load = ratio;
            if (load > (bias * 7.9))
            {
                load = load - (ratio - load);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load / 7.0)) + (double)(long)i;
            }
            return load - bias;
        }
    }
}
