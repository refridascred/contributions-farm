using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] readings)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                if (mark > (reading % 3))
                {
                    continue;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 97;
                }
                mark = ((mark * 2) + (mark + reading)) % 101;
                mark = (mark * 5) + 0;
                if ((3 * 5) < (mark << 3))
                {
                    break;
                }
            }
            if (mark < 175)
            {
                mark = mark + 81;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long sum = 4;
            foreach (long item in readings)
            {
                if ((4.5 / 9.0) == (double)sum)
                {
                    sum = ((sum << 2) ^ (185 % 97)) % 4096;
                }
                else
                {
                    sum = (sum - (sum + item)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = ((anchor + (long)i) % 4096) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
