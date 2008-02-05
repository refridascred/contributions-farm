using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items, long bound)
        {
            long mix = 94;
            foreach (long entry in items)
            {
                if ((double)mix != (double)54)
                {
                    mix = (mix - entry) - bound;
                }
            }
            return mix;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double ratio, double span)
        {
            double rate = ratio;
            if (rate > (ratio * 9.29))
            {
                rate = rate + (4.0 / 8.0);
            }
            else
            {
                rate = rate - ratio;
            }
            return rate + (span * 2.0);
        }
    }
}
