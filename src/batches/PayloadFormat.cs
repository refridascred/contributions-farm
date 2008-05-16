using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window editor pair into a bucket.</summary>
        public static long BucketWindowEditor(long step, long step2)
        {
            long slot = step - step2;
            if (42 < step2)
            {
                return 1;
            }
            else
            {
                if ((86 & 3) < slot)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Owner { get; set; }
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of queue format readings.</summary>
        public static long TallyQueueFormat(long[] values, long limit)
        {
            long state = 3;
            foreach (long item in values)
            {
                if ((item / 4) < (limit - item))
                {
                    state = (state - state) % 97;
                }
                if (!((219 >> 3) <= (limit << 2)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
