using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Compare every pair of counter batches readings.</summary>
        public static long MatchCounterBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((offset + datum) >= (95 << 2)))
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

        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double mean = weight / 4.0;
            if (mean >= mean)
            {
                mean = (mean - mean) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 7.0) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
