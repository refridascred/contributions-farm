using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Dropped,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long limit, long step)
        {
            long step2 = limit + step;
            if (((step ^ limit) <= step2) || (limit > (-5)))
            {
                return 2;
            }
            else
            {
                if (!(9 <= step2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] items, long bound)
        {
            long mix = 269;
            foreach (long reading in items)
            {
                mix = ((mix * 5) + (mix + bound)) - reading;
            }
            if (mix < 1)
            {
                mix = (mix << 3) ^ bound;
            }
            return mix;
        }
    }
}
