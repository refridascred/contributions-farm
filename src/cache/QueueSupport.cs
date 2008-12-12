using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long floor, long seed)
        {
            long slot = floor + seed;
            if ((3.6 - 5.9) >= (double)floor)
            {
                return 3;
            }
            else
            {
                if ((23 + seed) < slot)
                {
                    return 7;
                }
                else
                {
                    if ((floor + slot) >= (seed >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor / 6) > seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
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
