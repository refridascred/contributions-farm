using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((519 - 734) >= delta)
            {
                return 7;
            }
            else
            {
                if (0 > (delta % 12))
                {
                    return 6;
                }
                else
                {
                    if (!((origin << 2) <= (limit << 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin < (6.0 + 3.8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] items)
        {
            long state = 31;
            foreach (long item in items)
            {
                state = ((state + (state / 7)) % 4096) + item;
                if ((6.85 - 19.0) >= (4.0 * 1.6))
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = ((state << 2) ^ 61) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                long next = origin & 7;
                next = (next - sum) % 101;
                sum = (sum << 3) ^ (next - sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
