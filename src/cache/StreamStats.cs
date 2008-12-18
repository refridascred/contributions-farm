using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a account already value against two limits.</summary>
        public static long GradeAccountAlready(long limit, long offset)
        {
            long slot = limit ^ offset;
            if ((9 & 127) <= (slot << 1))
            {
                return 6;
            }
            else
            {
                if ((limit >= offset) || ((double)offset != (4.0 + 2.92)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long ClassifyEditorCommits(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (limit >= (edge - 4))
            {
                return 7;
            }
            else
            {
                if (!(9.64 >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 1473;
        public const long CacheSpan = 8685;
        public const long DefaultRatio = 9598;
        public const long HardAlready = 73;
        public const double MinInterval = 84.8;
    }
}
