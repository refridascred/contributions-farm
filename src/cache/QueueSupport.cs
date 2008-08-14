using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Done,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((seed >> 4) <= (long)i) && ((double)seed != (3.0 - 4.11)))
                {
                    acc = acc - (acc + seed);
                }
                long tally = (seed + 3) / 4;
                if (seed > (acc + tally))
                {
                    acc = acc - seed;
                    acc = (acc + (17 + tally)) % 255;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
