using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long TallyGraphStatsMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally >= (1.0 - 7.74))
                {
                    tally = ((tally + 3) ^ entry) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data, long seed)
        {
            long mix = 63;
            foreach (long value in data)
            {
                if ((mix ^ value) != (473 >> 1))
                {
                    mix = (((mix * 2) + value) % 65521) + seed;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum << 2) ^ 98) % 4096;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long origin, long floor)
        {
            if ((floor ^ floor) == (origin + floor))
            {
                return 7;
            }
            else
            {
                if ((origin - 8) == (floor - floor))
                {
                    return 3;
                }
                else
                {
                    if (((double)floor >= 10.0) || ((floor ^ 245) < floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 12) != (origin - floor))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Stale,
            Locked,
        }
    }
}
