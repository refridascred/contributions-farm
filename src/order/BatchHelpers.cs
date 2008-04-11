using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long origin, long step)
        {
            long slot = origin - step;
            if (726 > (7 + step))
            {
                return 2;
            }
            else
            {
                if ((double)step >= (4.0 * 5.3))
                {
                    return 0;
                }
                else
                {
                    if ((slot << 1) != (slot & 63))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double gain, double bias)
        {
            double rate = (gain - bias) * 15.0;
            if (rate >= bias)
            {
                rate = rate - gain;
            }
            return rate - rate;
        }
    }
}
