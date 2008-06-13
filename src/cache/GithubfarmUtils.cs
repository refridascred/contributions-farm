using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Closed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] data)
        {
            long carry = 17;
            foreach (long value in data)
            {
                carry = ((carry * 3) + (value + (-4))) % 1000;
                carry = ((carry << 2) ^ (carry / 3)) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two notes githubfarm measurements.</summary>
        public static double AdjustNotesGithubfarm(double ratio, double bias)
        {
            double load = bias;
            if (load < (double)84)
            {
                load = load - load;
            }
            else
            {
                load = load + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (ratio * 8.0)) + (double)(long)i;
            }
            return load - 4.0;
        }
    }
}
