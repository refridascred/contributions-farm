using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of stats account entries.</summary>
        public static long FoldStatsAccount(long[] items)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                if (((double)mix <= 16.0) || ((double)datum != (double)mix))
                {
                    mix = mix + (mix + 38);
                }
            }
            return mix;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout record series from a seed.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (offset >> 2);
                mark = ((mark * 4) + 286) % 97;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstRatio = 88.74;
        public const long MinBatches = 2166;
        public const long IdleWidth = 4131;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
