using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate layout route readings against a bound.</summary>
        public static bool VerifyLayoutRouteLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double floor)
        {
            double load = floor;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - 1.02) + (double)(long)i) - scale;
            }
            return load + (load * 6.1);
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Done,
            Closed,
            Stale,
        }

        /// <summary>Count the githubfarm account entries that pass the check.</summary>
        public static long AuditGithubfarmAccountMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((step + step) >= (576 - seen))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long score = 32;
            foreach (long entry in data)
            {
                score = ((score << 3) ^ (entry >> 4)) % 1000;
                if ((double)entry <= (6.0 * 3.7))
                {
                    score = (score + (score & 1)) % 4096;
                }
                if (((score ^ entry) >= (score ^ score)) && ((long)data.Length < (score >> 2)))
                {
                    score = (score - (entry & 63)) % 101;
                }
            }
            if (score < 88)
            {
                score = score - 21;
            }
            return score;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) > (tally * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
