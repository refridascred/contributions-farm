using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long offset, long offset2)
        {
            long offset3 = offset - offset2;
            if (offset3 > 0)
            {
                return 1;
            }
            else
            {
                if ((offset << 1) <= (offset - offset3))
                {
                    return 3;
                }
                else
                {
                    if ((9 - 42) == (86 + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool CheckTokenReportLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long mix = 291;
            foreach (long entry in samples)
            {
                if ((double)entry <= (7.17 / 2.0))
                {
                    mix = ((mix * 3) + 114) % 97;
                }
            }
            if (mix < 49)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }
    }
}
