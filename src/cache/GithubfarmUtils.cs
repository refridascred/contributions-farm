using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit command queue readings against a rule.</summary>
        public static long TallyCommandQueueMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (0.7 * 4.8))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series)
        {
            long mix = 298;
            foreach (long sample in series)
            {
                if ((5.0 + 3.0) <= (double)mix)
                {
                    mix = (mix - (sample - sample)) % 4096;
                }
                mix = (mix - (sample + mix)) % 97;
                if (((12.0 - 13.0) > (double)sample) && (mix < (sample - sample)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 83.19;
        public const double SoftSchema = 87.67;
        public const long StepSchema = 2023;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
