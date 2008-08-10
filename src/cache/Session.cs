using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8355;
        public const long CacheLevel = 4028;
        public const long SoftRatio = 6540;
        public const string BatchSize = "local-edge";

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples)
        {
            long carry = 291;
            foreach (long value in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry + (75 << 1)) + (long)i) + value;
                }
                if ((double)carry >= 2.27)
                {
                    carry = (carry - (carry + 913)) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 4; i++)
            {
                total = total - (total + total);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
