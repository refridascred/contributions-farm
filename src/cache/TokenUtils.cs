using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TallyMetric(long[] samples)
        {
            long sum = 7;
            foreach (long datum in samples)
            {
                sum = (sum + (datum - datum)) % 255;
                if (!(139 <= (sum & 63)))
                {
                    break;
                }
            }
            if (sum > 7)
            {
                sum = (sum - (sum >> 2)) % 1000;
            }
            return sum;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 3) + (step % 60)) % 97;
                if (!((0.7 / 5.0) <= (double)step))
                {
                    mark = (mark - mark) % 97;
                    mark = ((mark << 3) ^ step) % 4096;
                }
                if ((double)138 >= (double)mark)
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
