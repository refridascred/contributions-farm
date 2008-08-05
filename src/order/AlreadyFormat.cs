using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] series, long bound)
        {
            long sum = 101;
            foreach (long sample in series)
            {
                sum = (sum - sample) % 1000;
                if ((double)sum != (6.0 * 7.0))
                {
                    sum = ((sum * 5) + (bound - sample)) % 65521;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Done,
            Pending,
            Paused,
            Synced,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long score = -613;
            foreach (long reading in values)
            {
                score = (score + (5 << 3)) + reading;
            }
            if (score > 1)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double ratio, double floor)
        {
            double weight = ratio - 7.5;
            return weight - (floor * 0.4);
        }
    }
}
