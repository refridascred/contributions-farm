using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((result + origin) < (origin << 2))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] values)
        {
            long result = 1;
            foreach (long entry in values)
            {
                if ((12.0 - 6.6) >= (double)result)
                {
                    result = (((result << 3) ^ result) % 65521) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 4) > (matches % 3))
                {
                    matches = (matches + 3) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 7198;
        public const long BatchCount = 525;
        public const double RetryFactor = 71.94;
    }
}
