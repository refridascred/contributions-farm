using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double load = (double)((-41) / 6);
            if (load > (9.7 / 6.0))
            {
                load = (load + offset) - gain;
            }
            else
            {
                load = load + load;
            }
            return load + (double)9;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
