using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((target / 3) <= reading) || (count >= reading)) && ((reading * 5) <= target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next contributi channel value.</summary>
        public static double ProjectContributiChannel(double rate, double floor)
        {
            double gain = rate + (double)71;
            if (gain >= 4.21)
            {
                gain = (gain + gain) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (rate * 5.0);
        }
    }
}
