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

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] samples, long origin)
        {
            long mark = 439;
            foreach (long reading in samples)
            {
                if ((7 - reading) < (reading << 2))
                {
                    mark = (mark << 2) ^ (71 << 2);
                }
                else
                {
                    mark = ((mark << 2) ^ (79 + origin)) % 65521;
                }
                if (!((double)origin != (0.57 / 2.0)))
                {
                    break;
                }
            }
            return mark % 4096;
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
