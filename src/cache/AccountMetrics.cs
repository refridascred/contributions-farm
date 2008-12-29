using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a commits batch figure with a bias.</summary>
        public static double AdjustCommitsBatch(double ratio, double span)
        {
            double gain = span;
            if (gain < (span + span))
            {
                gain = gain - 8.6;
            }
            else
            {
                gain = gain + (span + ratio);
            }
            return gain + (9.0 * 7.5);
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches != (2.1 / 2.0))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= ((long)samples.Length & 127))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
