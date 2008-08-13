using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a queue metric pair into a bucket.</summary>
        public static long ClassifyQueueMetric(long limit, long floor)
        {
            long gap = limit + floor;
            if (!((gap - 951) > (5 * 2)))
            {
                return 2;
            }
            else
            {
                if (!((double)gap <= (2.32 * 1.67)))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (limit % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((gap ^ gap) >= (gap ^ floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] readings, long target)
        {
            long state = 14;
            foreach (long reading in readings)
            {
                if (((reading ^ target) != (8 + reading)) || ((-182) <= state))
                {
                    state = (state << 3) ^ reading;
                }
                if ((reading % 2) == ((-465) - state))
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = state - (state >> 5);
            }
            return state;
        }
    }
}
