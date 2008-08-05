using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long BucketBufferCluster(long step, long step2)
        {
            long next = step - step2;
            if (!((7.73 / 6.0) != (double)step2))
            {
                return 0;
            }
            else
            {
                if (7.2 < (double)next)
                {
                    return 5;
                }
                else
                {
                    if ((next << 3) >= (step + next))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the metric schema series from a seed.</summary>
        public static long RollMetricSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
