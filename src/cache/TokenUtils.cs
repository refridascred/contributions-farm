using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long AuditPayloadCommandOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((4.58 - 4.0) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cluster commits input into a small class.</summary>
        public static long GradeClusterCommits(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((bound - bound) != (97 + bound))
            {
                return 8;
            }
            else
            {
                if ((double)offset2 >= (3.47 - 9.1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
