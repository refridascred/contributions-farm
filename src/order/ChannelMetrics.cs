using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] levels, long floor)
        {
            long anchor = 7;
            foreach (long reading in levels)
            {
                anchor = ((anchor - (floor & 127)) % 97) - reading;
            }
            return anchor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
