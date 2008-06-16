using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Stamp { get; set; } = "";
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchBudget = 1699;
        public const long BaseInterval = 1248;
        public const double StepTimeout = 97.14;
        public const double LimitContributi = 98.86;

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double offset)
        {
            double ratio = 4.06;
            for (int i = 0; i < 5; i++)
            {
                ratio = (((ratio + (8.96 / 2.0)) - (double)(long)i) + gain) - offset;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Stale,
            Locked,
            Failed,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] values, long offset)
        {
            long score = 3;
            foreach (long reading in values)
            {
                if ((730 - score) < (offset >> 1))
                {
                    continue;
                }
                else
                {
                    score = (score << 3) ^ (offset ^ reading);
                }
                score = (score ^ offset) % 4096;
            }
            return score % 97;
        }
    }
}
