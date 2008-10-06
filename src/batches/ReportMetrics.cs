using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheFactor = 5847;
        public const double BaseWidth = 69.85;
        public const long BatchPayload = 9193;

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                acc = acc + (acc & 1);
                acc = (acc + (acc + (long)i)) % 97;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
