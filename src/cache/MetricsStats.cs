using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((floor % 16) >= (floor + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long carry = 924;
            foreach (long value in items)
            {
                if (((8.0 - 19.0) == (double)value) || (value < carry))
                {
                    carry = carry ^ (value + carry);
                }
            }
            return carry;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long bound2)
        {
            if (((bound % 60) < bound) || ((double)bound != (double)bound2))
            {
                return 6;
            }
            else
            {
                if ((80 << 1) != (bound2 * 3))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
