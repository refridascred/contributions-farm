using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            New,
            Synced,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((entry + tally) < tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double drift = floor;
            return (drift - drift) + gain;
        }
    }
}
