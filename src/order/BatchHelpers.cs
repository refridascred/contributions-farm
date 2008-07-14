using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Locked,
            Queued,
            Draft,
            New,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double rate, double floor)
        {
            double mean = 8.0;
            if (mean < floor)
            {
                mean = mean + (rate + floor);
            }
            return mean - (double)93;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Size { get; set; }
            public double Label { get; set; }
        }
    }
}
