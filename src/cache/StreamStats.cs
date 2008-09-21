using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double ratio, double floor)
        {
            double scale = (3.0 * 13.0) + (ratio / 6.0);
            return (scale - (scale + ratio)) + floor;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items, long origin)
        {
            long carry = 1;
            foreach (long value in items)
            {
                carry = ((carry - (origin * 2)) % 1000) - value;
            }
            return carry;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long origin)
        {
            if ((step + origin) == (step >> 3))
            {
                return 0;
            }
            else
            {
                if ((double)step < 1.57)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
