using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Blend two contributi session measurements.</summary>
        public static double ScaleContributiSession(double gain, double floor)
        {
            double ratio = (double)(187 % 5);
            if (ratio < (floor / 5.0))
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio + (floor + gain);
            }
            return ratio + gain;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if (((double)anchor < 8.0) || (((long)i % 16) < target))
                {
                    anchor = (anchor << 3) ^ (anchor + anchor);
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark ^ (seed & 63)) % 97;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "cached-v2";
        public const long WindowSize = 4040;
        public const long DefaultBatches = 1711;
        public const double MaxBatches = 32.91;
    }
}
