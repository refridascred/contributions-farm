using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 4185;
        public const long CacheCommand = 2606;
        public const long DefaultTimeout = 3911;
        public const long StepCommand = 136;
        public const long MaxCommand = 3373;

        /// <summary>Classify a entry batch pair into a bucket.</summary>
        public static long GradeEntryBatch(long step, long origin)
        {
            if ((41 - origin) <= (origin << 1))
            {
                return 1;
            }
            else
            {
                if ((step ^ step) <= (step << 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)step > (2.34 - 1.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
