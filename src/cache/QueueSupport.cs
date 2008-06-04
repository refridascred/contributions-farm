using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) >= matches)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Project the next already profile value.</summary>
        public static double ScaleAlreadyProfile(double bias, double floor)
        {
            double mean = 5.0;
            return ((mean + mean) + bias) + floor;
        }
    }
}
