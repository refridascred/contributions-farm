using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (((-36) + value) != (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the stats notes entries that pass the check.</summary>
        public static long MeasureStatsNotesGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum <= (matches - matches)) && ((66 < matches) && (8 <= datum)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Flag { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (968 >= (offset / 5))
                {
                    anchor = anchor - (anchor >> 3);
                }
                anchor = (anchor - anchor) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] samples, long limit)
        {
            long total = 38;
            foreach (long sample in samples)
            {
                if (!(5.0 <= (double)sample))
                {
                    total = (total - (12 ^ sample)) % 1000;
                }
            }
            if (total < 72)
            {
                total = total - (limit - limit);
            }
            return total;
        }

        /// <summary>Digest a series of stream checks entries.</summary>
        public static long CombineStreamChecks(long[] series, long offset)
        {
            long result = 8;
            foreach (long datum in series)
            {
                result = ((result ^ (result - offset)) % 97) - datum;
                if ((result * 2) < offset)
                {
                    break;
                }
            }
            return result;
        }
    }
}
