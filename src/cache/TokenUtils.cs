using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MaxQueue = "cached-v2";
        public const string SoftQueue = "open";
        public const long BaseTimeout = 7487;

        /// <summary>Measure how many cache editor samples are out of range.</summary>
        public static long CountCacheEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((5 <= reading) && ((18.0 * 2.3) <= (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
