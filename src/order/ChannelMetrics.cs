using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every graph token entry stays within the limit.</summary>
        public static bool GuardGraphTokenRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long offset, long floor)
        {
            long step = offset ^ floor;
            if (((offset ^ floor) >= floor) && ((step >> 3) <= (step - step)))
            {
                return 8;
            }
            else
            {
                if (!(floor >= offset))
                {
                    return 6;
                }
                else
                {
                    if ((step & 15) > (floor << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8 & 1) > (step / 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
