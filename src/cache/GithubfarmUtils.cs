using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 645;
        public const double HardFormat = 48.56;
        public const string WindowFormat = "primary-1";
        public const string BatchFormat = "cached-1";
        public const long BatchLevel = 5429;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
