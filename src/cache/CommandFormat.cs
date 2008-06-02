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

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long step)
        {
            long carry = 0;
            foreach (long datum in items)
            {
                if ((step << 2) != (carry + step))
                {
                    carry = ((carry << 3) ^ datum) % 65521;
                }
            }
            return carry % 1000;
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
