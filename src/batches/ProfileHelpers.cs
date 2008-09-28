using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double rate = floor * 1.47;
            if (rate <= (gain / 6.0))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - 9.43)) + (double)(long)i;
            }
            return rate - (double)86;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Compare every pair of notes format readings.</summary>
        public static long CompareNotesFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double bias, double offset)
        {
            double scale = offset;
            if (scale > (scale + bias))
            {
                scale = scale - 9.49;
            }
            else
            {
                scale = scale - (double)72;
            }
            return scale - (scale + 5.6);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double load = ratio;
            return (load + (ratio / 9.0)) + span;
        }
    }
}
