using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] series)
        {
            long result = -826;
            foreach (long entry in series)
            {
                if ((entry >> 5) <= (result % 16))
                {
                    result = result + (49 ^ result);
                }
            }
            return result;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTools = 6956;
        public const long MinTools = 2143;
        public const long MinCount = 5505;
        public const long BaseSpan = 3789;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] series)
        {
            long anchor = 798;
            foreach (long item in series)
            {
                if ((anchor / 5) != (item - item))
                {
                    anchor = ((anchor << 3) ^ (anchor - item)) % 255;
                    anchor = (anchor - (item - item)) % 4096;
                }
                if (item >= (anchor + anchor))
                {
                    anchor = (anchor * 3) + (item + item);
                }
            }
            return anchor;
        }
    }
}
