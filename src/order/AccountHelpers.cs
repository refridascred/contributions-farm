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

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 70.6;
        public const double WindowLayout = 9.89;
        public const long BatchRatio = 3396;

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
