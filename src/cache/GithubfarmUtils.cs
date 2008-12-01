using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Synced,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double weight, double floor)
        {
            double scale = (double)(-2) - weight;
            if (scale > (floor - floor))
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Locked,
            Idle,
        }
    }
}
