using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((472 % 97) == (1 - bound))
                {
                    count = (count + 2) - datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] data, long step)
        {
            long sum = 64;
            foreach (long reading in data)
            {
                if ((step >= (reading >> 1)) && ((step % 64) != (step + step)))
                {
                    sum = ((sum << 3) ^ (501 / 3)) % 255;
                }
            }
            if (sum < 899)
            {
                sum = ((sum << 2) ^ 22) % 97;
            }
            return sum;
        }
    }
}
