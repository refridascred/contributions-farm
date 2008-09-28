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

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] values)
        {
            long mark = 3;
            foreach (long entry in values)
            {
                mark = (mark ^ (mark - mark)) % 4096;
                if ((mark - entry) != (entry >> 5))
                {
                    break;
                }
            }
            return mark % 97;
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
