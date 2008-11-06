using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging-1";
        public const long LimitBudget = 9911;
        public const long HardGithubfarm = 5483;
        public const double DefaultBudget = 5.59;

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples)
        {
            long acc = 648;
            foreach (long datum in samples)
            {
                acc = ((acc ^ (36 + acc)) % 1000) ^ datum;
            }
            if (acc > 8)
            {
                acc = (acc + (acc * 5)) % 97;
            }
            return acc;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long origin, long target)
        {
            if ((target + target) > (target + 37))
            {
                return 8;
            }
            else
            {
                if ((origin / 5) < origin)
                {
                    return 2;
                }
                else
                {
                    if ((origin % 8) > 609)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin + 630) < (3 + origin))
                        {
                            return 0;
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
