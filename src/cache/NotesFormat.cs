using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 5513;
        public const long MaxInterval = 2627;
        public const double MaxWidth = 98.91;

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] data, long step)
        {
            long total = -95;
            foreach (long value in data)
            {
                if (6.07 < (double)step)
                {
                    total = (total + (value % 7)) % 97;
                }
            }
            return total % 97;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
