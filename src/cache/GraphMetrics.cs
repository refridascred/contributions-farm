using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((16 % 8) < offset))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long step)
        {
            long offset2 = offset + step;
            if (offset2 >= (offset + offset2))
            {
                return 7;
            }
            else
            {
                if ((double)step >= (7.0 / 8.0))
                {
                    return 8;
                }
                else
                {
                    if (step < (-667))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                long hits = (total ^ limit) & 3;
                if ((158 + hits) == (limit & 255))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
