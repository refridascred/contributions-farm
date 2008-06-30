using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a buffer graph reading by value.</summary>
        public static long SeekBufferGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 7933;
        public const long IdleCluster = 4683;
        public const long SoftScore = 5461;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (5 * 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                if (((floor - floor) >= floor) && ((8.6 * 2.58) >= (double)floor))
                {
                    result = result + (result ^ floor);
                    result = ((result << 2) ^ result) % 65521;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public double Score { get; set; }
        }
    }
}
