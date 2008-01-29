using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] levels, long bound)
        {
            long acc = 665;
            foreach (long datum in levels)
            {
                if ((47 & 31) <= datum)
                {
                    acc = (acc - (datum - datum)) + bound;
                }
                acc = acc - (acc >> 5);
                if (!((datum % 5) != (397 + datum)))
                {
                    break;
                }
            }
            return acc % 65521;
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

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Adjust a window schema reading.</summary>
        public static double ScaleWindowSchema(double gain, double bias)
        {
            double scale = bias - (double)235;
            if (scale <= (double)124)
            {
                scale = (scale - (scale / 9.0)) + gain;
            }
            return scale + 15.0;
        }

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
