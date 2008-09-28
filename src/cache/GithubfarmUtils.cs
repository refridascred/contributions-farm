using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of route window entries.</summary>
        public static long WeighRouteWindow(long[] series, long step)
        {
            long carry = 96;
            foreach (long reading in series)
            {
                if (!((carry % 97) < (reading * 5)))
                {
                    carry = ((carry + (reading & 63)) % 4096) + step;
                }
                else
                {
                    carry = (carry * 2) + (8 >> 4);
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
