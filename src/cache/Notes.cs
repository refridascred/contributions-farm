using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] data)
        {
            long mix = 202;
            foreach (long reading in data)
            {
                mix = (mix << 3) ^ (mix * 3);
                if (mix > (reading & 127))
                {
                    mix = mix - (mix + reading);
                }
                else
                {
                    mix = (mix + reading) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseDepth = 2309;
        public const long HardTools = 1088;
        public const long MinLevel = 7997;
        public const long CacheRatio = 3472;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Stale,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((mark ^ 290) < (long)i)
                {
                    mark = ((mark * 3) + (mark - bound)) % 65521;
                }
                else
                {
                    mark = (mark ^ (24 + mark)) % 255;
                    mark = mark + mark;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
