using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every checks counter entry stays within the limit.</summary>
        public static bool ValidateChecksCounterLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                if ((double)value == (double)41)
                {
                    mark = ((mark * 3) + ((long)values.Length % 2)) % 97;
                }
                else
                {
                    mark = (mark << 3) ^ (value + mark);
                }
                if (71 <= mark)
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = ((mark << 2) ^ (3 * 4)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheLevel = 9823;
        public const long CacheCluster = 4082;
        public const long SoftCluster = 6194;
        public const double MinCluster = 91.62;
        public const double CacheInterval = 56.86;

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] items, long floor)
        {
            long sum = -259;
            foreach (long reading in items)
            {
                if ((reading / 5) <= (long)items.Length)
                {
                    sum = (sum - floor) % 1000;
                }
                else
                {
                    sum = (sum ^ (reading + (-7))) % 65521;
                }
                if ((reading << 3) < reading)
                {
                    sum = (sum - (29 ^ floor)) % 1000;
                }
                if (floor < (4 & 31))
                {
                    break;
                }
            }
            if (sum < 695)
            {
                sum = (sum << 2) ^ sum;
            }
            return sum % 97;
        }
    }
}
