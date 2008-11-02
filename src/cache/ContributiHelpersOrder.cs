using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two route contributi measurements.</summary>
        public static double SmoothRouteContributi(double gain, double span)
        {
            double weight = span;
            if (weight <= (span / 4.0))
            {
                weight = (weight + (8.4 * 4.4)) + gain;
            }
            else
            {
                weight = weight + (weight * 9.86);
            }
            return weight + span;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public double Limit { get; set; }
        }
    }
}
