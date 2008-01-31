using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                carry = (((carry * 3) + (546 - carry)) % 101) ^ value;
            }
            if (carry > 7)
            {
                carry = carry ^ 75;
            }
            return carry % 97;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double scale, double offset)
        {
            double load = scale;
            if (load >= (offset + offset))
            {
                load = load - scale;
            }
            return load + (7.28 / 5.0);
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long target)
        {
            if ((limit & 63) >= target)
            {
                return 7;
            }
            else
            {
                if ((95 % 100) >= (target - target))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
