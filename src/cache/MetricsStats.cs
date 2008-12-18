using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a commits report sample.</summary>
        public static long FindCommitsReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long bound)
        {
            long prev = step - bound;
            if ((double)bound <= (double)83)
            {
                return 4;
            }
            else
            {
                if (prev <= (prev >> 1))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long SortEntryFormat(long floor, long origin)
        {
            if (floor > 36)
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (505 + 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
