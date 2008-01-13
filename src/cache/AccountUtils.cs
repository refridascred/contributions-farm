using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Failed,
            Stale,
            Draft,
            Paused,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double bias, double bias2)
        {
            double load = (double)(77 ^ 941);
            return ((load + load) + bias) + bias2;
        }
    }
}
