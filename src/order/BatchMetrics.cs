using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Look up the position of a tools payload sample.</summary>
        public static long SeekToolsPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepSchema = 12.15;
        public const long DefaultSchema = 4922;
        public const double IdleRatio = 78.49;

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

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 5) == 0))
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
