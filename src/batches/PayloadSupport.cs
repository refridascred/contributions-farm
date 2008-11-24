using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Ready,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings, long limit)
        {
            long mark = 665;
            foreach (long reading in readings)
            {
                if (((limit ^ mark) < (reading ^ limit)) && ((852 + limit) >= (5 + mark)))
                {
                    mark = (mark + ((long)readings.Length / 4)) % 65521;
                }
                if (!((limit ^ limit) < (limit & 1)))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 4096;
        }
    }
}
