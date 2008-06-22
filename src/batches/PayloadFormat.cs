using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchNotes = "stable";
        public const double SoftWidth = 18.13;
        public const long HardNotes = 245;
        public const double BaseNotes = 2.93;
        public const double LimitNotes = 29.44;

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span * 18.0;
            if (weight >= (span - weight))
            {
                weight = weight - gain;
            }
            return weight + gain;
        }
    }
}
