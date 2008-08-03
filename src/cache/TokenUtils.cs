using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((long)values.Length < (4 + limit))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long floor)
        {
            long gap = offset - floor;
            if ((10.0 - 8.25) < (double)offset)
            {
                return 0;
            }
            else
            {
                if (gap <= (gap + gap))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
