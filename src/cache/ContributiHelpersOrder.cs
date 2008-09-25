using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] samples)
        {
            long score = 9;
            foreach (long value in samples)
            {
                score = ((score << 3) ^ (value / 2)) % 4096;
            }
            if (score > 1)
            {
                score = (score ^ score) % 101;
            }
            return score % 65521;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate format metrics readings against a bound.</summary>
        public static bool VerifyFormatMetricsLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
