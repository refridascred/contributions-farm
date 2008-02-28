using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = (score + ((long)i ^ origin)) % 97;
                score = (score - (score & 3)) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry + entry) <= entry) || ((count & 7) <= (532 / 5))) || (((entry % 100) <= count) || (count < entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Total { get; set; }
            public double Weight { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank checks token input into a small class.</summary>
        public static long ClassifyChecksToken(long offset, long limit)
        {
            long slot = offset + limit;
            if (((offset - slot) > (slot % 8)) && (515 < offset))
            {
                return 5;
            }
            else
            {
                if (((limit ^ offset) != (slot - slot)) || ((limit % 10) <= (slot + offset)))
                {
                    return 2;
                }
                else
                {
                    if (((slot % 64) == (limit + slot)) && ((double)offset != (9.5 - 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
