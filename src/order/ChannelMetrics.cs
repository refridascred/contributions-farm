using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)floor <= (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
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
