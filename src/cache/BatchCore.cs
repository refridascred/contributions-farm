using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3923;
        public const long BatchScore = 3865;
        public const long LimitInterval = 9086;
        public const long DefaultEntry = 6875;

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
