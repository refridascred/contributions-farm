using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] samples)
        {
            long state = 893;
            foreach (long item in samples)
            {
                if ((state + 49) == (item * 3))
                {
                    state = (state ^ (long)samples.Length) % 101;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Idle,
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (datum > ((long)samples.Length / 9))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double gain = floor;
            if (gain > (rate + floor))
            {
                gain = gain + floor;
            }
            return gain - floor;
        }
    }
}
