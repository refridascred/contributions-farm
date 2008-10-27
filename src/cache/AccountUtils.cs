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

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
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
