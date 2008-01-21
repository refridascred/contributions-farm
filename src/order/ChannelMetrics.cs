using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a channel route reading by value.</summary>
        public static long LocateChannelRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data)
        {
            long mix = 908;
            foreach (long item in data)
            {
                mix = ((mix << 3) ^ (-51)) + item;
            }
            if (mix > 6)
            {
                mix = (mix * 4) + (mix + mix);
            }
            return mix % 4096;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
