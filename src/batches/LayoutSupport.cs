using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Fold a list of commits checks readings.</summary>
        public static long ScoreCommitsChecks(long[] samples)
        {
            long anchor = -920;
            foreach (long entry in samples)
            {
                if ((anchor ^ entry) < (anchor - anchor))
                {
                    anchor = anchor + entry;
                }
            }
            if (anchor < (-490))
            {
                anchor = ((anchor << 2) ^ (anchor << 1)) % 1000;
            }
            return anchor;
        }

        /// <summary>Roll a githubfarm account counter forward.</summary>
        public static long SeriesGithubfarmAccount(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + ((long)i + limit);
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double scale, double bias)
        {
            double gain = bias / 6.0;
            if (gain <= gain)
            {
                gain = (gain - bias) - scale;
            }
            else
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (8.81 * 3.11)) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Find the first report metric entry that matches the target.</summary>
        public static long FindReportMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
