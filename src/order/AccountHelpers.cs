using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a token order pair into a bucket.</summary>
        public static long ClassifyTokenOrder(long step, long target)
        {
            long diff = step + target;
            if (step < target)
            {
                return 2;
            }
            else
            {
                if ((135 >= diff) && ((step % 16) < target))
                {
                    return 7;
                }
                else
                {
                    if (target >= diff)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((diff < target) && ((double)step != (6.36 - 6.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of farm window readings.</summary>
        public static long TallyFarmWindow(long[] samples, long target)
        {
            long total = 740;
            foreach (long reading in samples)
            {
                total = (((total * 4) + (target % 100)) % 97) ^ reading;
                if ((total - 11) == (0 >> 2))
                {
                    continue;
                }
                total = (total << 2) ^ (total << 1);
                if ((total - target) != (target - target))
                {
                    break;
                }
            }
            if (total < 994)
            {
                total = (total - total) % 4096;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftBudget = 0.43;
        public const long StepWindow = 1526;
        public const long MaxWindow = 6605;
        public const long MinFactor = 3317;
        public const string DefaultWindow = "alpha-v2";

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Ready,
            New,
            Locked,
            Draft,
        }
    }
}
