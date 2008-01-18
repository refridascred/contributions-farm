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

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
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
