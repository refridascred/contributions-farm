using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double gain = (floor * 9.3) / 3.0;
            if (gain < floor)
            {
                gain = gain - (weight / 5.0);
            }
            else
            {
                gain = gain - (floor / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - (double)885;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Failed,
            Active,
            Dropped,
            Draft,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (count > (value % 2))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
