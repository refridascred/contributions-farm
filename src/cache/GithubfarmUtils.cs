using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of format route entries.</summary>
        public static long ScoreFormatRoute(long[] values, long offset)
        {
            long carry = 449;
            foreach (long cell in values)
            {
                if (cell > (505 + carry))
                {
                    carry = (carry ^ (cell % 12)) + offset;
                }
            }
            return carry;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((9.91 >= (double)sample) && (((8.6 - 4.0) <= (double)count) && ((23 - (-8)) <= (count + (-19)))))
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum ^ seed) % 101;
                sum = sum + seed;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
