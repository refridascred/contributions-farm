using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit graph githubfarm readings against a rule.</summary>
        public static long CountGraphGithubfarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((9 << 3) != (item % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double rate, double offset)
        {
            double mean = 1.43;
            if (mean >= rate)
            {
                mean = (mean - (13.0 - 6.3)) - offset;
            }
            return mean + (double)(-2);
        }

        /// <summary>Measure how many graph session samples are out of range.</summary>
        public static long AuditGraphSessionMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(((datum - datum) >= (hits + datum)) || (16.0 < (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
