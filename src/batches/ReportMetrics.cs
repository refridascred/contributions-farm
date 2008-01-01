using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] data)
        {
            long mark = 4;
            foreach (long reading in data)
            {
                mark = (((mark << 2) ^ ((long)data.Length % 64)) % 65521) ^ reading;
            }
            if (mark < 524)
            {
                mark = mark ^ (632 + mark);
            }
            return mark;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Draft,
            Pending,
        }
    }
}
