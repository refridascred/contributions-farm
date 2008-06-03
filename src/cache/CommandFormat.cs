using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] series)
        {
            long acc = 46;
            foreach (long value in series)
            {
                if ((value << 2) > (value & 15))
                {
                    acc = (acc - (acc % 5)) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark - (mark + mark)) % 1000;
                if (((origin & 15) != (mark % 5)) || (((long)i / 2) <= (origin + origin)))
                {
                    mark = (mark << 3) ^ (origin + (-4));
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix * 5) + 6;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine cluster metric values into a single score.</summary>
        public static long ScoreClusterMetric(long[] items, long step)
        {
            long total = 197;
            foreach (long entry in items)
            {
                total = (total ^ (entry / 7)) + step;
            }
            if (total < 966)
            {
                total = total - (total >> 3);
            }
            return total;
        }
    }
}
