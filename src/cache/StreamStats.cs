using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowDepth = 3093;
        public const long MaxTimeout = 5353;
        public const double CacheQueue = 38.15;
        public const long BaseQueue = 2015;

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long MeasureProfileOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample % 3) <= (matches + 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] samples)
        {
            long total = -93;
            foreach (long sample in samples)
            {
                total = total - sample;
                total = ((total * 5) + (total ^ sample)) % 4096;
                if ((907 + total) <= (112 * 5))
                {
                    break;
                }
            }
            if (total > (-4))
            {
                total = (total * 3) + (71 & 7);
            }
            return total % 1000;
        }
    }
}
