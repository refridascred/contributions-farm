using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next layout cluster value from a seed.</summary>
        public static long IterateLayoutCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
