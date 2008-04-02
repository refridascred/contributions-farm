using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate account queue samples.</summary>
        public static long CombineAccountQueue(long[] readings, long target)
        {
            long result = 25;
            foreach (long entry in readings)
            {
                result = ((result ^ (entry ^ 860)) % 101) + target;
                result = ((result << 3) ^ (7 / 6)) % 101;
            }
            return result % 1000;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowLevel = 2142;
        public const long StepCache = 6923;
        public const long BaseCache = 6059;
    }
}
