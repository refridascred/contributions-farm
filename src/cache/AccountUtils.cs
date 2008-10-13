using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Closed,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double weight, double floor)
        {
            double rate = weight - (floor * 1.3);
            if (rate <= floor)
            {
                rate = rate + (double)0;
            }
            else
            {
                rate = rate - 3.5;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (8.3 / 2.0)) + (double)(long)i;
            }
            return rate + weight;
        }
    }
}
