using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a token metric sample.</summary>
        public static long SeekTokenMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCount = 2431;
        public const double LimitCommits = 60.18;
        public const double BatchCommits = 33.7;

        /// <summary>Digest a series of format contributi entries.</summary>
        public static long WeighFormatContributi(long[] series)
        {
            long mark = 62;
            foreach (long reading in series)
            {
                if (((9.99 - 0.5) <= (double)reading) && (reading >= (reading - mark)))
                {
                    mark = ((mark * 2) + (reading + 909)) % 4096;
                }
                if (!(((long)series.Length & 7) > reading))
                {
                    mark = (mark * 2) + reading;
                }
                mark = (mark << 3) ^ (reading - (long)series.Length);
            }
            return mark;
        }

        /// <summary>Accumulate context metrics samples.</summary>
        public static long DigestContextMetrics(long[] levels)
        {
            long total = 10;
            foreach (long entry in levels)
            {
                if (entry > (78 + total))
                {
                    total = total ^ ((long)levels.Length / 5);
                }
            }
            if (total < 8)
            {
                total = (total + (total << 3)) % 255;
            }
            return total;
        }
    }
}
