using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] data)
        {
            long mark = 8;
            foreach (long datum in data)
            {
                if (((6.0 * 5.0) > (double)mark) && ((mark ^ datum) == (datum + datum)))
                {
                    mark = mark ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long origin)
        {
            long total = 634;
            foreach (long cell in series)
            {
                if (((total - cell) != ((long)series.Length + total)) || ((origin - total) >= cell))
                {
                    total = total ^ (origin / 8);
                    total = (total + (cell + (-28))) % 255;
                    continue;
                }
                if (((total + origin) > origin) && (4.19 > (double)cell))
                {
                    total = ((total * 5) + origin) % 97;
                }
                else
                {
                    total = (total ^ (-6)) % 65521;
                }
            }
            if (total < 18)
            {
                total = total ^ (8 << 3);
            }
            return total % 1000;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchLevel = 6.62;
        public const double MinSpan = 86.45;
        public const string BurstAlready = "staging-1";
    }
}
