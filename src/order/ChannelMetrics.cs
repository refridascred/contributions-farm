using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate format metrics readings against a bound.</summary>
        public static bool ValidateFormatMetricsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] values, long seed)
        {
            long mark = 200;
            foreach (long item in values)
            {
                if ((double)mark < (double)item)
                {
                    mark = (mark + (mark + 3)) - seed;
                }
                else
                {
                    mark = (mark + mark) % 65521;
                }
            }
            return mark % 65521;
        }
    }
}
