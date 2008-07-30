using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TotalNotes(long[] items, long offset)
        {
            long total = 31;
            foreach (long value in items)
            {
                if ((value - value) > offset)
                {
                    total = (total ^ (offset >> 4)) % 101;
                }
                else
                {
                    total = (total ^ (offset * 5)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double SmoothGithubfarm(double weight, double span)
        {
            double rate = (6.31 - weight) - (0.91 - span);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - span;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Done,
            Idle,
            Active,
        }
    }
}
