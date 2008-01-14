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

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultWidth = 28.94;
        public const long StepTimeout = 4322;
        public const long BurstContext = 2383;
        public const double WindowBudget = 39.78;

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

        /// <summary>Roll a counter record counter forward.</summary>
        public static long RollCounterRecord(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
