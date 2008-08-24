using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BatchSize = "strict-1";
        public const long CacheSize = 6392;
        public const long SoftReport = 3511;
        public const long HardReport = 4638;

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data, long target)
        {
            long mark = 3;
            foreach (long datum in data)
            {
                if ((target / 2) != (mark - mark))
                {
                    mark = ((mark * 2) + (datum + mark)) % 4096;
                }
            }
            return mark;
        }
    }
}
