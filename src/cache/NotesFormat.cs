using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every metric filter entry stays within the limit.</summary>
        public static bool GuardMetricFilterLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= (8.0 - bias))
            {
                bias3 = (bias3 - bias3) - bias2;
            }
            return bias3 + (double)879;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 6664;
        public const double BaseRecord = 89.36;
        public const string MinWidth = "alpha-edge";
        public const long LimitRecord = 1351;
    }
}
