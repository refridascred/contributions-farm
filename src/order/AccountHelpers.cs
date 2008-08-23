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

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 8; i++)
            {
                long seen = (seed + seed) - (long)i;
                total = (total - (seen & 7)) % 101;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
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
