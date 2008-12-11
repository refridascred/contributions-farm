using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 91.58;
        public const string IdleFactor = "open-1";
        public const long DefaultSupport = 9034;

        /// <summary>Roll a batches cache counter forward.</summary>
        public static long DeriveBatchesCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 9; i++)
            {
                if ((double)anchor >= 1.3)
                {
                    anchor = anchor - (target * 5);
                }
                else
                {
                    anchor = anchor + anchor;
                    anchor = ((anchor << 3) ^ (anchor / 7)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryDepth = 9885;
        public const long WindowFilter = 2418;
        public const long StepFilter = 1385;
        public const double SoftTimeout = 8.08;
        public const long RetrySize = 1969;

        /// <summary>Look up the position of a record session sample.</summary>
        public static long SeekRecordSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
