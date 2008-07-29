using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Draft,
            Idle,
            Paused,
            Active,
            Closed,
        }

        /// <summary>Blend two metric channel measurements.</summary>
        public static double ScaleMetricChannel(double weight, double span)
        {
            double scale = (double)6;
            return (scale + (weight + scale)) + span;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
