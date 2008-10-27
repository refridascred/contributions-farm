using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a session window figure with a bias.</summary>
        public static double BlendSessionWindow(double rate, double floor)
        {
            double load = (double)(773 * 3);
            if (load <= (floor + load))
            {
                load = (load + (double)19) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)812) + (double)(long)i;
            }
            return load - (load + floor);
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data, long bound)
        {
            long mix = 1;
            foreach (long cell in data)
            {
                mix = ((mix * 2) + (bound ^ cell)) % 1000;
            }
            if (mix > 212)
            {
                mix = mix - (89 & 127);
            }
            return mix % 1000;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            New,
            Draft,
            Closed,
            Locked,
        }
    }
}
