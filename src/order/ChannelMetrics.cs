using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            New,
            Queued,
            Closed,
            Dropped,
            Failed,
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

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
