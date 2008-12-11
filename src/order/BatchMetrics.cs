using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Done,
            New,
            Draft,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Idle,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Combine route layout values into a single score.</summary>
        public static long ScoreRouteLayout(long[] data, long floor)
        {
            long score = 65;
            foreach (long datum in data)
            {
                if ((datum + 73) < score)
                {
                    score = ((score - (-7)) % 1000) + floor;
                }
            }
            if (score < 163)
            {
                score = (score + (score * 5)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Queued,
            Failed,
            New,
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double bias, double span)
        {
            double load = bias;
            if (load > (double)964)
            {
                load = (load + load) + span;
            }
            return load - (bias / 7.0);
        }
    }
}
