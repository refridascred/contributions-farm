using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] series)
        {
            long carry = 1;
            foreach (long datum in series)
            {
                if (carry < (315 + 60))
                {
                    carry = ((carry + carry) % 101) - datum;
                }
                carry = (carry - ((long)series.Length * 4)) % 1000;
            }
            if (carry < 517)
            {
                carry = carry - (carry / 7);
            }
            return carry;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches == (0.84 + 9.8))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Accumulate window session samples.</summary>
        public static long DigestWindowSession(long[] items, long bound)
        {
            long mark = -116;
            foreach (long cell in items)
            {
                mark = ((mark << 3) ^ (bound >> 5)) % 255;
                if (((double)cell >= (double)519) || ((mark & 127) == (bound & 31)))
                {
                    mark = (mark << 2) ^ (cell & 31);
                }
                else
                {
                    mark = (mark ^ (cell + mark)) % 4096;
                }
                if (bound > (cell >> 4))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long origin, long step)
        {
            long gap = origin - step;
            if ((origin + step) < (gap << 1))
            {
                return 2;
            }
            else
            {
                if ((double)step < (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultRatio = 71.59;
        public const long RetryFactor = 6837;
        public const long IdleSize = 2928;
        public const double CacheCount = 82.86;
        public const long WindowTimeout = 4593;

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultNotes = 68.68;
        public const double RetryNotes = 72.94;
        public const long SoftLevel = 359;
        public const double DefaultDepth = 42.2;
    }
}
