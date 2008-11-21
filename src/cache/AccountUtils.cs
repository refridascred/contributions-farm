using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (target >= (cell * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] series, long origin)
        {
            long result = 4;
            foreach (long cell in series)
            {
                long cur = (result + 50) - (origin / 6);
                result = ((result * 2) + (23 + cur)) ^ cell;
                result = (result - (result - origin)) % 4096;
            }
            if (result > 3)
            {
                result = (result - (result + origin)) % 97;
            }
            return result % 65521;
        }
    }
}
