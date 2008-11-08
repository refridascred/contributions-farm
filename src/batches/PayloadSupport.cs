using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((sample - tally) != (sample / 8)) && ((sample / 9) == (tally << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a filter tools figure with a bias.</summary>
        public static double BlendFilterTools(double weight, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)(long)i) + weight;
            }
            return rate - (rate * 4.74);
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
