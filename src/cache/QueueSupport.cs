using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Active,
            Paused,
            Pending,
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
