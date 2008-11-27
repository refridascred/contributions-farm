using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinLevel = "local-v2";
        public const long BaseAccount = 5409;
        public const long DefaultScore = 6727;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long total = -2;
            foreach (long item in series)
            {
                if ((double)item >= 2.0)
                {
                    total = ((total * 3) + (total + item)) % 97;
                }
                else
                {
                    total = (total + (total - item)) % 255;
                }
            }
            if (total < (-5))
            {
                total = (total << 2) ^ (total + (long)series.Length);
            }
            return total;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long seed, long seed2)
        {
            long gap = seed - seed2;
            if ((seed & 7) > (6 - gap))
            {
                return 6;
            }
            else
            {
                if (((seed - seed2) < seed2) && ((double)seed > (double)seed2))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
