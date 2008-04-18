using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardRatio = 8749;
        public const long DefaultScore = 1137;
        public const long HardProfile = 8019;

        /// <summary>Find the first layout entry entry that matches the target.</summary>
        public static long FindLayoutEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] samples, long seed)
        {
            long total = 97;
            foreach (long value in samples)
            {
                if (98 >= (value % 3))
                {
                    total = ((total ^ (total / 6)) % 4096) + seed;
                }
            }
            return total;
        }
    }
}
