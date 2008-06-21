using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double weight, double span)
        {
            double ratio = weight;
            if (ratio >= 3.31)
            {
                ratio = (ratio + (ratio - 9.17)) + span;
            }
            else
            {
                ratio = ratio + (double)546;
            }
            return ratio + (ratio * 18.0);
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long AuditFilterContributiHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item >= 6.57)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
