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

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double offset)
        {
            double scale = 7.6 * 3.5;
            if (scale < (gain / 3.0))
            {
                scale = (scale - 7.67) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (1.5 / 7.0);
        }
    }
}
