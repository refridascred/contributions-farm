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

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Synced,
            Retry,
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
