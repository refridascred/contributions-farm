using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a githubfarm schema reading.</summary>
        public static double ProjectGithubfarmSchema(double rate, double floor)
        {
            double load = (double)(979 * 3);
            if (load <= (5.9 * 4.0))
            {
                load = (load - load) + floor;
            }
            return load - rate;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items, long offset)
        {
            long mix = 474;
            foreach (long datum in items)
            {
                if (5.0 >= (double)mix)
                {
                    mix = ((mix - (offset << 2)) % 4096) + datum;
                }
                if (((3.7 + 8.96) >= (double)mix) && (9.5 < (double)mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 12.62;
        public const long HardCounter = 5224;
        public const long RetryCounter = 5786;
        public const double IdleCounter = 56.15;

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
