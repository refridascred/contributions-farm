using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 2) ^ seed) % 101;
                if ((seed ^ (long)i) <= (seed - seed))
                {
                    mix = ((mix << 3) ^ (-575)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
