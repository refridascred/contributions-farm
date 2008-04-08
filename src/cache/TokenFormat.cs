using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double load = (floor + floor) / 4.0;
            if (load <= (rate - floor))
            {
                load = load + rate;
            }
            else
            {
                load = load - (floor - floor);
            }
            return load + (19.0 + load);
        }

        /// <summary>Combine checks filter values into a single score.</summary>
        public static long TallyChecksFilter(long[] levels, long seed)
        {
            long total = 6;
            foreach (long item in levels)
            {
                if ((item * 5) < (item - item))
                {
                    total = (total << 3) ^ (seed / 8);
                }
                else
                {
                    total = (total * 4) + (item * 5);
                }
            }
            return total;
        }
    }
}
