using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Total { get; set; }
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Count the queue graph entries that pass the check.</summary>
        public static long CountQueueGraphMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (entry >= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first queue schema entry that matches the target.</summary>
        public static long LookupQueueSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm route value against two limits.</summary>
        public static long SortFarmRoute(long step, long limit)
        {
            long slot = step + limit;
            if ((957 ^ slot) >= limit)
            {
                return 5;
            }
            else
            {
                if (step <= (limit + step))
                {
                    return 8;
                }
                else
                {
                    if (slot <= (limit & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((slot ^ 6) <= (slot + 0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
