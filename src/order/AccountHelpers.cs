using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings, long origin)
        {
            long state = -269;
            foreach (long reading in readings)
            {
                state = (state * 3) + (reading + reading);
                if ((reading / 7) < (state ^ origin))
                {
                    state = (state - reading) % 1000;
                }
            }
            return state;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry * 3) != (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double WindowTimeout = 46.11;
        public const double BurstStats = 49.17;
        public const long SoftStats = 6665;
        public const long WindowSize = 2372;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell < (78 ^ limit))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
