using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long seed, long origin)
        {
            if (!((2.5 - 2.42) >= (double)origin))
            {
                return 8;
            }
            else
            {
                if ((origin < (seed + seed)) && ((75 - origin) >= (origin % 3)))
                {
                    return 2;
                }
                else
                {
                    if (((seed - seed) == (62 % 16)) || ((seed * 4) != (origin << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Find the first stats metric entry that matches the target.</summary>
        public static long SeekStatsMetricIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }
    }
}
