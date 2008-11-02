using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine payload route values into a single score.</summary>
        public static long WeighPayloadRoute(long[] samples, long bound)
        {
            long total = 3;
            foreach (long item in samples)
            {
                total = (total + (item >> 4)) - bound;
            }
            return total % 1000;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long sum = 58;
            foreach (long entry in levels)
            {
                if (1 > (sum - sum))
                {
                    sum = ((sum - sum) % 1000) ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > weight)
            {
                weight2 = weight2 - 6.78;
            }
            return weight2 - (weight2 - floor);
        }
    }
}
