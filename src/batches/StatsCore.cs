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

        /// <summary>Count the format report entries that pass the check.</summary>
        public static long MeasureFormatReportHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) > datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long target, long seed)
        {
            long span = target ^ seed;
            if (((seed - span) <= (target >> 2)) && ((span / 6) != (seed + target)))
            {
                return 8;
            }
            else
            {
                if (!((5.58 - 4.98) > (double)target))
                {
                    return 3;
                }
                else
                {
                    if (!(5.0 < (double)span))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

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
