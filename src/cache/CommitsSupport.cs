using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 7214;
        public const long DefaultBudget = 3398;
        public const string WindowWidth = "alpha";
        public const long StepCache = 3104;

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] series)
        {
            long state = 101;
            foreach (long entry in series)
            {
                if ((state << 1) >= (entry >> 4))
                {
                    state = (state * 2) + state;
                }
            }
            if (state > 715)
            {
                state = (state ^ (state >> 4)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Draft,
            Synced,
            New,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Closed,
            Failed,
            Pending,
            Idle,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] samples, long target)
        {
            long sum = 504;
            foreach (long sample in samples)
            {
                if (((9.6 - 4.05) == (double)sample) || ((6.4 / 8.0) >= (double)(long)samples.Length))
                {
                    sum = sum - (sum & 31);
                }
                if ((target + sum) != (target << 3))
                {
                    sum = (sum << 3) ^ ((long)samples.Length + sum);
                }
                else
                {
                    sum = sum ^ (sum % 16);
                }
            }
            if (sum > 915)
            {
                sum = (sum << 2) ^ (target - target);
            }
            return sum % 1000;
        }
    }
}
