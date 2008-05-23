using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double rate, double span)
        {
            double rate2 = 0.43 + 20.0;
            return (rate2 - (rate / 7.0)) + span;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double offset)
        {
            double weight = offset;
            return (weight + 6.2) + gain;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Locked,
            Dropped,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Scale a report schema figure with a bias.</summary>
        public static double ProjectReportSchema(double scale, double span)
        {
            double scale2 = 1.69;
            if (scale2 <= (span - 6.0))
            {
                scale2 = scale2 - span;
            }
            else
            {
                scale2 = scale2 + (7.3 + span);
            }
            return scale2 + (span - scale);
        }
    }
}
