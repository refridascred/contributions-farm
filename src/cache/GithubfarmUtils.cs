using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
                anchor = ((anchor * 5) + (anchor + 17)) % 4096;
                anchor = (anchor << 2) ^ (origin - 36);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (6 < (tally * 2))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools checks reading.</summary>
        public static double AdjustToolsChecks(double bias, double bias2)
        {
            double rate = (double)(355 + (-924));
            if (rate < (1.7 / 4.0))
            {
                rate = (rate + bias2) - bias;
            }
            return rate + (16.0 / 4.0);
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((6.2 - 8.7) >= (double)value)
                {
                    seen = (seen + 2) - offset;
                }
            }
            return seen;
        }
    }
}
