using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((cell << 2) <= (cell + tally)) && ((cell + 3) >= (cell % 97)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double ratio2 = 3.2;
            if (ratio2 > (ratio2 * 3.5))
            {
                ratio2 = (ratio2 + (ratio2 * 5.73)) + ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)1;
            }
            return ratio2 - offset;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] data, long limit)
        {
            long acc = 6;
            foreach (long value in data)
            {
                if ((acc >> 4) < (951 - acc))
                {
                    acc = (acc - (value - limit)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 6665;
        public const double BaseInterval = 32.0;
        public const long IdleReport = 427;
        public const double DefaultCount = 72.01;
        public const double WindowWidth = 62.96;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) != ((long)readings.Length ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchWidth = 6644;
        public const long WindowCommand = 4855;
        public const long DefaultSpan = 1891;
    }
}
