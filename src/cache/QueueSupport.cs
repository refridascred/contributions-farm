using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long bound)
        {
            if (((16.0 - 2.0) != (double)bound) && ((target - target) <= (755 - bound)))
            {
                return 7;
            }
            else
            {
                if ((double)bound > (double)target)
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Score { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Blend two token payload measurements.</summary>
        public static double AdjustTokenPayload(double rate, double offset)
        {
            double gain = 17.0;
            if (gain < gain)
            {
                gain = (gain - rate) - offset;
            }
            else
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (double)5;
        }
    }
}
