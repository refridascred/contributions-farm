using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor - 3;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of window report entries.</summary>
        public static long ScoreWindowReport(long[] series, long offset)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                if ((3 / 6) > mark)
                {
                    mark = ((mark ^ (mark + mark)) - cell) - offset;
                }
            }
            if (mark > 89)
            {
                mark = (mark * 5) + 8;
            }
            return mark % 1000;
        }
    }
}
