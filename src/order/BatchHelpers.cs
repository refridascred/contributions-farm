using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double ratio, double floor)
        {
            double gain = (double)51 - ratio;
            if (gain <= gain)
            {
                gain = (gain - (double)8) - floor;
            }
            else
            {
                gain = gain + (double)64;
            }
            return gain + (double)32;
        }

        /// <summary>Locate a payload queue reading by value.</summary>
        public static long FindPayloadQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
