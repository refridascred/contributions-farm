using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine layout window values into a single score.</summary>
        public static long TotalLayoutWindow(long[] readings, long offset)
        {
            long acc = 72;
            foreach (long cell in readings)
            {
                acc = ((acc + (offset & 15)) % 255) ^ cell;
            }
            if (acc < 937)
            {
                acc = (acc ^ (offset + acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(hits <= (1 - hits)))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 7568;
        public const string CacheDepth = "cached";
        public const string WindowCluster = "strict";

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                if (((double)carry == (5.8 / 8.0)) && ((datum + (-5)) <= (carry * 5)))
                {
                    carry = (carry ^ datum) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Done,
            Paused,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Stale,
            Locked,
            Paused,
            Failed,
        }
    }
}
