using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] items)
        {
            long result = 0;
            foreach (long reading in items)
            {
                result = (result ^ (reading * 3)) % 97;
                result = result + (6 << 1);
                result = (result ^ (reading << 2)) % 255;
            }
            return result;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 6306;
        public const double DefaultCount = 96.7;
        public const long BurstAlready = 8445;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long result = 40;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) <= (result / 7)) && ((-5) < entry))
                {
                    result = result ^ (result + entry);
                }
            }
            return result;
        }
    }
}
