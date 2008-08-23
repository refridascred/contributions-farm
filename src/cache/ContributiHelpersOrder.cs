using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double rate, double span)
        {
            double gain = (double)(8 >> 5);
            if (gain > 9.9)
            {
                gain = (gain - (double)3) - rate;
            }
            return gain - (span / 6.0);
        }

        /// <summary>Classify a order contributi pair into a bucket.</summary>
        public static long SortOrderContributi(long origin, long bound)
        {
            if (origin <= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((bound + origin) != (origin + 10))
                {
                    return 6;
                }
                else
                {
                    if (!((double)origin >= 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches <= (6.2 + 10.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }
    }
}
