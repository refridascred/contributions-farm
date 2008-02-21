using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cache window readings against a rule.</summary>
        public static long TallyCacheWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + tally) < (reading ^ reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the commits counter entries that pass the check.</summary>
        public static long TallyCommitsCounterHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((double)hits == (double)sample) && ((hits + step) >= sample)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double load = span + (9.3 - span);
            if (load > (span - 6.4))
            {
                load = load - (10.0 - gain);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (7.87 / 8.0)) + (double)(long)i;
            }
            return load + (gain - load);
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
