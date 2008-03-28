using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long total = 918;
            foreach (long cell in series)
            {
                if (cell < (cell / 9))
                {
                    total = total ^ (8 ^ bound);
                }
            }
            return total % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-edge";
        public const long RetryQueue = 6517;
        public const string HardSpan = "local-1";
        public const long StepLevel = 2965;
    }
}
