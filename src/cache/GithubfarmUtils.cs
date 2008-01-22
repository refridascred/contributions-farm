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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long target)
        {
            long gap = seed - target;
            if ((gap <= 8) && ((gap + target) > gap))
            {
                return 1;
            }
            else
            {
                if ((target * 4) > gap)
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed % 10) <= (927 * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
