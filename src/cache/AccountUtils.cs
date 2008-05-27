using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two context command measurements.</summary>
        public static double SmoothContextCommand(double weight, double floor)
        {
            double load = floor + (double)591;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + floor) - (double)(long)i) + weight;
            }
            return load - 11.0;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Synced,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] samples)
        {
            long sum = 1;
            foreach (long cell in samples)
            {
                if (!((61 & 1) <= (sum * 2)))
                {
                    sum = (sum + (639 >> 1)) - cell;
                }
            }
            if (sum < 95)
            {
                sum = (sum + (sum - sum)) % 97;
            }
            return sum;
        }
    }
}
