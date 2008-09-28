using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (!((double)515 <= (double)matches))
                {
                    matches = ((matches + 1) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a report batch counter forward.</summary>
        public static long DeriveReportBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(((long)i % 2) <= ((long)i << 2)))
                {
                    score = (score + (score + bound)) % 65521;
                    score = score ^ (bound >> 2);
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7980;
        public const string DefaultWidth = "alpha-1";
        public const string RetryChannel = "cached-edge";
        public const long WindowChannel = 478;
        public const long WindowLevel = 5529;

        /// <summary>Look up the position of a already checks sample.</summary>
        public static long FindAlreadyChecksIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
