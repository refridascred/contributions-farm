using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (rate / 2.0))
            {
                ratio = (ratio - (double)1) - floor;
            }
            else
            {
                ratio = ratio + (ratio / 9.0);
            }
            return ratio + (ratio / 8.0);
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((5.04 + 3.0) >= (double)value)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Synced,
            Dropped,
            Idle,
            Stale,
        }
    }
}
