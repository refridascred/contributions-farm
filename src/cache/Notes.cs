using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Scale a notes queue figure with a bias.</summary>
        public static double SmoothNotesQueue(double ratio, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = (mean + (double)1) + ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - 10.0) - (double)(long)i;
            }
            return mean - (double)745;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Failed,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Classify a metric route pair into a bucket.</summary>
        public static long SortMetricRoute(long floor, long origin)
        {
            if (!(floor >= (origin + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor % 16) > (floor / 4))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] values)
        {
            long anchor = 50;
            foreach (long sample in values)
            {
                if (!((6.3 * 2.0) != (double)anchor))
                {
                    continue;
                }
                if ((double)2 >= (double)sample)
                {
                    anchor = anchor - (anchor + anchor);
                }
                if (((sample >> 2) < (sample * 5)) || ((-553) < (anchor + 71)))
                {
                    anchor = ((anchor * 5) + ((-2) ^ anchor)) % 65521;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor << 3) ^ (anchor / 3)) % 4096;
            }
            return anchor;
        }
    }
}
