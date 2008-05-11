using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double rate, double bias)
        {
            double drift = 3.0;
            if (drift > rate)
            {
                drift = (drift + 8.0) + bias;
            }
            return drift - rate;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Closed,
            Done,
            Queued,
        }
    }
}
