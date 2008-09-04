using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Paused,
            Closed,
            Retry,
            New,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Draft,
            Queued,
            Idle,
            New,
        }

        /// <summary>Project the next githubfarm farm value.</summary>
        public static double ScaleGithubfarmFarm(double ratio, double floor)
        {
            double scale = 13.0;
            if (scale > ratio)
            {
                scale = scale - scale;
            }
            return scale - (floor - scale);
        }
    }
}
