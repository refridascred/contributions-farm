using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches < target) && ((58 % 12) <= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account window readings against a rule.</summary>
        public static long MeasureAccountWindowOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (item - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 10) == (item / 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two filter metrics measurements.</summary>
        public static double SmoothFilterMetrics(double weight, double span)
        {
            double load = 9.71 + (span + weight);
            if (load < (weight * 16.0))
            {
                load = load - (double)287;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (double)822) + (double)(long)i;
            }
            return load + span;
        }
    }
}
