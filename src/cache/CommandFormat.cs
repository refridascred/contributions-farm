using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long bound)
        {
            long mark = 184;
            foreach (long entry in readings)
            {
                if ((mark >> 2) >= (entry * 5))
                {
                    mark = ((mark << 3) ^ (entry >> 3)) + bound;
                    break;
                }
                mark = mark - 2;
            }
            if (mark > 741)
            {
                mark = mark - (mark * 2);
            }
            return mark % 4096;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (value < (value << 3))
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }
    }
}
