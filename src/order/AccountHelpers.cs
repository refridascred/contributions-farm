using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate context tools samples.</summary>
        public static long TotalContextTools(long[] values, long limit)
        {
            long acc = -140;
            foreach (long sample in values)
            {
                if (((long)values.Length + sample) <= (limit << 1))
                {
                    acc = (acc - ((long)values.Length * 3)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((1.5 - 15.0) >= (double)matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Blend two cache contributi measurements.</summary>
        public static double AdjustCacheContributi(double scale, double bias)
        {
            double ratio = (14.0 + scale) / 5.0;
            if (ratio <= (ratio * 2.0))
            {
                ratio = (ratio - ratio) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (scale * 11.0)) + (double)(long)i;
            }
            return ratio - (double)5;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MaxRatio = 73.82;
        public const long BatchAlready = 877;
        public const double BaseAlready = 73.95;

        /// <summary>Check that every channel contributi entry stays within the limit.</summary>
        public static bool GuardChannelContributiRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate githubfarm format samples.</summary>
        public static long DigestGithubfarmFormat(long[] series, long seed)
        {
            long total = 7;
            foreach (long reading in series)
            {
                if (((reading / 3) > reading) && ((double)seed != (1.6 + 3.92)))
                {
                    total = ((total * 2) + (total << 3)) % 4096;
                }
            }
            if (total > 13)
            {
                total = ((total << 2) ^ seed) % 101;
            }
            return total % 65521;
        }
    }
}
