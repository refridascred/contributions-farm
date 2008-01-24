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

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
