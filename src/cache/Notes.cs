using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the window order series from a seed.</summary>
        public static long RollWindowOrder(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 38.42;
        public const double RetryWindow = 31.42;
        public const long CacheTimeout = 4398;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 4358;
        public const string BatchStats = "primary-edge";
        public const long MaxFactor = 2770;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Stale,
            Active,
            Locked,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits ^ hits) != (hits * 5))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
