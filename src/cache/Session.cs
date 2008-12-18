using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of layout command entries.</summary>
        public static long TallyLayoutCommand(long[] levels)
        {
            long mix = 326;
            foreach (long reading in levels)
            {
                mix = (mix + ((long)levels.Length + reading)) % 4096;
                mix = mix - (mix - mix);
                mix = ((mix << 3) ^ (mix - 146)) % 1000;
            }
            return mix;
        }

        /// <summary>Combine counter order values into a single score.</summary>
        public static long WeighCounterOrder(long[] items)
        {
            long mark = 314;
            foreach (long cell in items)
            {
                mark = mark ^ (mark - mark);
                if (5.48 < (double)cell)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches % 3) == (72 / 7))
                {
                    matches = ((matches + 3) - value) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - floor;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
