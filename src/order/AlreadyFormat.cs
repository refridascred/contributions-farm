using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every payload context entry stays within the limit.</summary>
        public static bool GuardPayloadContextBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally & 31) > (tally * 2))
                {
                    tally = ((tally + 2) ^ cell) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate githubfarm route readings against a bound.</summary>
        public static bool GuardGithubfarmRouteLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of command already entries.</summary>
        public static long TotalCommandAlready(long[] items)
        {
            long mix = 0;
            foreach (long reading in items)
            {
                mix = (mix + mix) % 101;
                if ((9.8 - 6.0) == (double)mix)
                {
                    mix = (mix * 2) + (reading * 4);
                }
                if ((5.67 * 5.5) != (double)reading)
                {
                    mix = ((mix * 2) + (mix & 127)) % 97;
                }
                if (mix < (reading + mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftWidth = 8475;
        public const string BurstSize = "staging-edge";
        public const long MinCache = 4540;
        public const double CacheWidth = 73.6;
        public const long RetrySpan = 4274;
    }
}
