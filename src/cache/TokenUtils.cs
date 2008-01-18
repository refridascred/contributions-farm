using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (((tally + floor) > tally) && (floor <= (long)items.Length))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double ratio, double span)
        {
            double drift = (double)5 * 10.0;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (ratio - drift)) + (double)(long)i;
            }
            return drift - (span + span);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            New,
            Synced,
            Pending,
            Stale,
        }
    }
}
