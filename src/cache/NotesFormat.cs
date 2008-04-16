using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two route contributi measurements.</summary>
        public static double AdjustRouteContributi(double bias, double bias2)
        {
            double load = bias;
            for (int i = 0; i < 6; i++)
            {
                load = ((load - (double)873) + (double)(long)i) + bias2;
            }
            return load + (bias / 9.0);
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Active,
            Queued,
        }
    }
}
