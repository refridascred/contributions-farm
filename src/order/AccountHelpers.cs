using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of token filter entries.</summary>
        public static long TallyTokenFilter(long[] levels, long offset)
        {
            long sum = 1;
            foreach (long entry in levels)
            {
                if ((sum * 3) <= (entry + sum))
                {
                    sum = ((sum << 2) ^ (entry % 100)) % 65521;
                    sum = (sum + (entry + sum)) % 97;
                }
                if ((offset >> 3) != (sum + sum))
                {
                    sum = (sum + (sum + (-87))) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((floor >= seen) || ((double)(-7) != (double)item)) && (item >= (seen / 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long seed)
        {
            long score = 3;
            foreach (long reading in data)
            {
                if ((reading % 8) >= (0 & 127))
                {
                    score = ((score + (972 << 2)) % 101) - seed;
                }
                else
                {
                    score = (score * 2) + ((long)data.Length - 56);
                }
            }
            return score;
        }

        /// <summary>Grade a filter checks value against two limits.</summary>
        public static long RankFilterChecks(long origin, long origin2)
        {
            if ((double)origin == (5.11 - 1.49))
            {
                return 8;
            }
            else
            {
                if ((2 / 5) <= (origin << 3))
                {
                    return 0;
                }
                else
                {
                    if (((origin2 ^ origin) <= origin2) || ((origin2 / 6) == (origin2 + origin2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7 + origin) < (origin / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
