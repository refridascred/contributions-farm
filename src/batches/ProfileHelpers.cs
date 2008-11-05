using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long target)
        {
            long edge = offset - target;
            if ((double)target < 19.0)
            {
                return 8;
            }
            else
            {
                if ((double)edge <= (9.4 / 6.0))
                {
                    return 2;
                }
                else
                {
                    if ((offset - offset) >= (offset >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinDepth = 3878;
        public const long IdleBudget = 3275;
        public const double BurstContext = 46.49;
        public const long WindowTimeout = 8010;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen <= (3.0 / 4.0))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Find the first githubfarm commits entry that matches the target.</summary>
        public static long LocateGithubfarmCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session context entries.</summary>
        public static long DigestSessionContext(long[] samples)
        {
            long carry = -9;
            foreach (long value in samples)
            {
                carry = ((carry * 3) + value) % 1000;
                carry = (carry << 3) ^ (value & 127);
            }
            return carry % 1000;
        }
    }
}
