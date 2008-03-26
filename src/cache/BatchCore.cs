using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Paused,
            New,
            Closed,
            Pending,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double AdjustQueue(double scale, double bias)
        {
            double rate = bias;
            if (rate < (3.7 / 3.0))
            {
                rate = rate + (bias * 9.0);
            }
            return rate - scale;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Active,
            Draft,
            Failed,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Queued,
            Done,
        }
    }
}
