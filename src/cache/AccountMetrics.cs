using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Size { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] levels, long bound)
        {
            long anchor = 81;
            foreach (long value in levels)
            {
                anchor = (((anchor * 4) + anchor) % 4096) ^ value;
                if (((-487) - bound) <= bound)
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long MatchBufferCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 72;
            foreach (long value in series)
            {
                mark = (mark * 3) + (value + mark);
            }
            return mark % 97;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) != (bound << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
