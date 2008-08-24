using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double rate, double offset)
        {
            double bias = (double)(-432);
            if (bias < (rate - offset))
            {
                bias = bias + 9.88;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (double)(-73);
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Draft,
            Locked,
            Done,
            Ready,
        }
    }
}
