using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long origin)
        {
            long result = origin;
            for (int i = 0; i < 14; i++)
            {
                if (!(((result ^ (long)i) != (66 % 60)) || ((double)result <= (8.0 * 2.68))))
                {
                    result = (result * 4) + origin;
                    result = (result ^ 39) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
