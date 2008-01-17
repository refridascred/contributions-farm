using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double ratio, double offset)
        {
            double rate = offset * 8.89;
            return rate + (ratio / 7.0);
        }

        /// <summary>Find the first batch support entry that matches the target.</summary>
        public static long LookupBatchSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a order payload figure with a bias.</summary>
        public static double AdjustOrderPayload(double scale, double offset)
        {
            double mean = (offset * 5.0) - (offset / 7.0);
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean + (offset / 3.0)) - (double)(long)i) - scale;
            }
            return mean - (double)54;
        }
    }
}
