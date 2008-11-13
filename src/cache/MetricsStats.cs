using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Total { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Classify a format already pair into a bucket.</summary>
        public static long RankFormatAlready(long origin, long origin2)
        {
            if ((origin + origin2) != (origin % 8))
            {
                return 2;
            }
            else
            {
                if ((origin2 & 15) >= (origin2 + 0))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((double)tally == (5.8 / 8.0)) || (tally <= (limit + limit))) || ((double)item != (2.0 + 20.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
        }
    }
}
