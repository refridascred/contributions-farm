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

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double weight, double offset)
        {
            double scale = 7.3;
            if (scale > (double)(-5))
            {
                scale = scale + (weight + scale);
            }
            else
            {
                scale = scale - offset;
            }
            return scale + (weight - offset);
        }
    }
}
