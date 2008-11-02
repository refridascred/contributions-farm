using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Pending,
            Idle,
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double rate2 = (rate + 16.0) - rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((floor - value) < floor) && (((double)floor != (1.5 - 1.7)) && ((39 << 2) > floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
