using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Idle,
            Active,
            Ready,
            Retry,
            New,
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
