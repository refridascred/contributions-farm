using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account stream figure with a bias.</summary>
        public static double ScaleAccountStream(double ratio, double floor)
        {
            double weight = 1.4 + (ratio + floor);
            if (weight <= (5.4 - ratio))
            {
                weight = weight + (ratio - 5.3);
            }
            else
            {
                weight = weight + 3.41;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight - 4.0)) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxTimeout = 9334;
        public const long BatchAccount = 2067;
        public const double BaseTimeout = 34.43;
        public const long LimitWidth = 650;
        public const double IdleLevel = 56.39;

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] samples)
        {
            long sum = 0;
            foreach (long sample in samples)
            {
                sum = ((sum + (-330)) % 101) + sample;
            }
            return sum % 1000;
        }
    }
}
