using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double load = (7.0 + floor) + (gain * 9.6);
            if (load < (gain / 7.0))
            {
                load = load - (14.0 * 0.83);
            }
            return load - (double)321;
        }

        /// <summary>Combine profile format values into a single score.</summary>
        public static long WeighProfileFormat(long[] data, long floor)
        {
            long sum = 67;
            foreach (long item in data)
            {
                if (!((floor << 3) <= (67 - item)))
                {
                    sum = (sum + (sum + 82)) % 255;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Dropped,
            Pending,
        }
    }
}
