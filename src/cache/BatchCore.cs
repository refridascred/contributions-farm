using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate queue token readings against a bound.</summary>
        public static bool CheckQueueTokenLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Project the next checks channel value.</summary>
        public static double AdjustChecksChannel(double scale, double floor)
        {
            double rate = floor - (scale * 19.0);
            return rate - rate;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double weight, double offset)
        {
            double gain = weight + (double)299;
            if (gain > (6.0 * 2.0))
            {
                gain = gain - weight;
            }
            else
            {
                gain = gain - (gain * 10.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + offset;
        }
    }
}
