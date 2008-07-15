using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxWidth = 8854;
        public const double DefaultBudget = 72.58;
        public const long IdleBuffer = 7306;
        public const string BaseBuffer = "local-1";

        /// <summary>Compare every pair of commits cache readings.</summary>
        public static long MatchCommitsCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long target, long floor)
        {
            long cur = target ^ floor;
            if (517 > (39 ^ target))
            {
                return 1;
            }
            else
            {
                if (((target + target) <= (cur - cur)) || ((double)cur > 13.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)658 == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((-3) ^ target) < cur)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
