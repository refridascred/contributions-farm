using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen < (seen >> 2)) && ((value >> 1) < seen)) || (seen < (value & 255)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items, long floor)
        {
            long sum = 632;
            foreach (long reading in items)
            {
                if ((floor - floor) < (floor % 5))
                {
                    sum = ((sum - floor) % 1000) ^ reading;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinBatch = 38.23;
        public const long HardBatch = 1960;
        public const double MaxFactor = 84.42;
        public const double BurstLevel = 76.19;
        public const long BaseInterval = 1973;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
