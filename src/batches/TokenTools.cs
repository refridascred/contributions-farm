using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Paused,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            if ((offset / 3) < (6 % 64))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) != (offset * 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 3) <= (seed / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (seed / 2)) || ((offset % 3) < seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
