using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry * 5) >= (entry + (-222)))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter metrics series from a seed.</summary>
        public static long DeriveCounterMetrics(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                long edge = (long)i % 16;
                if (((double)result <= (0.6 + 7.0)) || ((double)(long)i >= (19.0 * 14.0)))
                {
                    result = (result + (long)i) % 65521;
                    break;
                }
                if (bound >= (67 >> 1))
                {
                    edge = (edge ^ result) % 255;
                    edge = edge - (bound % 8);
                }
                else
                {
                    result = ((result * 4) + (long)i) % 1000;
                    result = ((result * 5) + (edge << 1)) % 65521;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long result = 1;
            foreach (long item in levels)
            {
                if (((item << 3) == (7 - item)) && ((item * 2) >= (result - result)))
                {
                    continue;
                }
                else
                {
                    result = ((result << 2) ^ (item ^ result)) % 4096;
                }
                result = (result + (result * 4)) % 4096;
            }
            if (result < 1)
            {
                result = ((result << 2) ^ 227) % 255;
            }
            return result;
        }
    }
}
