using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double rate, double bias)
        {
            double rate2 = (bias * 9.5) - (bias * 3.0);
            return rate2 + (rate - 1.95);
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long anchor = 111;
            foreach (long item in samples)
            {
                anchor = (anchor - (item ^ item)) % 65521;
            }
            return anchor;
        }
    }
}
