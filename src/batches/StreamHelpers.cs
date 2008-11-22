using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor + (long)i) >= (anchor >> 1))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long CountSchemaQueueMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits & 255) >= (61 - entry))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics batches readings.</summary>
        public static long TallyMetricsBatches(long[] samples, long origin)
        {
            long mark = -434;
            foreach (long entry in samples)
            {
                if ((origin + mark) > entry)
                {
                    mark = mark + 8;
                    mark = (mark << 3) ^ entry;
                }
                else
                {
                    mark = (mark << 2) ^ (79 ^ origin);
                }
                mark = (mark << 2) ^ (entry - mark);
            }
            if (mark < 965)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (limit > hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Mode { get; set; }
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
