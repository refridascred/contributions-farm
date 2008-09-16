using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (double)964)
                {
                    matches = (matches + 3) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample - (long)samples.Length) <= sample)
                {
                    count = count + 3;
                }
            }
            return count;
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
