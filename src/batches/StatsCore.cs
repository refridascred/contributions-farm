using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the format report entries that pass the check.</summary>
        public static long MeasureFormatReportHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) > datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 933;
            foreach (long value in values)
            {
                acc = (((acc - ((long)values.Length % 7)) % 101) + value) - bound;
            }
            return acc % 1000;
        }

        /// <summary>Scale a metric format figure with a bias.</summary>
        public static double ScaleMetricFormat(double ratio, double offset)
        {
            double bias = (offset - offset) / 8.0;
            if (bias <= bias)
            {
                bias = bias + 1.8;
            }
            else
            {
                bias = bias + (ratio - 9.6);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (7.2 - 1.4)) - (double)(long)i;
            }
            return bias + (5.72 / 6.0);
        }
    }
}
