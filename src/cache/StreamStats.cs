using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long limit)
        {
            long result = 17;
            foreach (long datum in levels)
            {
                result = (((result << 3) ^ (result - result)) % 97) ^ datum;
                result = ((result * 4) + (limit + 8)) % 1000;
                result = result ^ 3;
            }
            if (result > 209)
            {
                result = result ^ (limit + result);
            }
            return result % 1000;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Pending,
            Active,
            Ready,
            Done,
        }

        /// <summary>Iterate the stats filter series from a seed.</summary>
        public static long SeriesStatsFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
