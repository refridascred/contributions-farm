using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Closed,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Weight { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double scale = (double)((-516) << 3);
            if (scale >= ratio)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + (scale * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale + 1.7)) - (double)(long)i;
            }
            return scale + bias;
        }
    }
}
