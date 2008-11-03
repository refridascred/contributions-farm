using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the batches report series from a seed.</summary>
        public static long DeriveBatchesReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(((long)i * 5) > target))
                {
                    anchor = (anchor - (anchor & 15)) % 97;
                }
                anchor = (anchor + ((long)i + target)) % 1000;
                anchor = (anchor - (anchor * 4)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a channel githubfarm reading by value.</summary>
        public static long SeekChannelGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((19 % 97) > (entry & 7))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 82.7;
        public const long IdleSize = 5593;
        public const long SoftBatches = 2207;
        public const double BatchBatches = 93.68;
    }
}
