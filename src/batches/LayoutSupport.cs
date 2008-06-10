using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                long count = score;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score * 5) + ((-713) + count)) % 97) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Compare every pair of account stream readings.</summary>
        public static long OverlapAccountStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Failed,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Count contributi githubfarm pairs that satisfy a relation.</summary>
        public static long PairContributiGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
