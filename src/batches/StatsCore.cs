using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally < 5.0)
                {
                    tally = ((tally + 3) + sample) - offset;
                }
            }
            return tally;
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

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public double Mode { get; set; }
            public string Rank { get; set; } = "";
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

        /// <summary>Combine checks command values into a single score.</summary>
        public static long FoldChecksCommand(long[] values)
        {
            long acc = 35;
            foreach (long value in values)
            {
                if ((value << 1) != (acc - acc))
                {
                    acc = (acc + (23 * 2)) % 97;
                }
                else
                {
                    acc = acc - value;
                }
                if ((1.05 / 5.0) > (double)acc)
                {
                    acc = acc - (value ^ 339);
                }
                else
                {
                    acc = (acc << 2) ^ (298 + 3);
                }
            }
            return acc % 4096;
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
