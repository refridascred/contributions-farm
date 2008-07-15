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

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] levels)
        {
            long sum = -2;
            foreach (long item in levels)
            {
                if (!((1.4 * 20.0) == (double)item))
                {
                    sum = (sum * 4) + (sum & 1);
                }
                else
                {
                    sum = (sum ^ (item + sum)) % 97;
                }
            }
            if (sum < 2)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }
    }
}
