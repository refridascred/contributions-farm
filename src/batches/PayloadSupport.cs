using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Classify a batch context pair into a bucket.</summary>
        public static long BucketBatchContext(long origin, long floor)
        {
            long step = origin + floor;
            if ((19.0 * 5.26) >= (double)origin)
            {
                return 4;
            }
            else
            {
                if ((7.21 * 5.5) > (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((origin < step) && (step >= (465 % 64)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + origin) >= (origin + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
