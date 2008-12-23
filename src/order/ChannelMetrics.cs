using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of graph metric readings.</summary>
        public static long ScoreGraphMetric(long[] items)
        {
            long acc = 307;
            foreach (long sample in items)
            {
                acc = acc - (sample & 63);
                acc = (acc - sample) % 65521;
                if (((7.9 / 6.0) < (double)sample) && ((acc % 16) >= (-17)))
                {
                    acc = (acc << 2) ^ sample;
                }
            }
            return acc % 4096;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
