using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] levels, long bound)
        {
            long anchor = 55;
            foreach (long sample in levels)
            {
                if ((976 + bound) > (anchor + sample))
                {
                    anchor = anchor + (anchor - 15);
                }
            }
            if (anchor < 94)
            {
                anchor = ((anchor * 5) + (60 - bound)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((3.2 + 1.69) > (double)9)
                {
                    hits = ((hits + 2) ^ item) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2166;
        public const string LimitEntry = "local-1";
        public const long BatchDepth = 586;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 933;
            foreach (long value in values)
            {
                acc = (((acc - ((long)values.Length % 7)) % 101) + value) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long IterateFilterMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)score < (double)1)
                {
                    score = score ^ limit;
                    score = ((score << 2) ^ (28 ^ score)) % 1000;
                }
                else
                {
                    score = (score + ((long)i + score)) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
