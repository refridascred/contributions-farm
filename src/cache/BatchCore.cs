using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double rate, double span)
        {
            double mean = (double)(0 & 31);
            if (mean > (double)(-65))
            {
                mean = mean - rate;
            }
            else
            {
                mean = mean + span;
            }
            return mean - (rate * 14.0);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor ^ (offset % 12)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long CountCounterRouteHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((0 << 1) == (reading * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
