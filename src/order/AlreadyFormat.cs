using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Paused,
            Queued,
            New,
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double scale = (7.43 / 6.0) * 2.3;
            if (scale < ratio)
            {
                scale = scale + (span + 5.08);
            }
            return scale - (double)6;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double bias, double floor)
        {
            double load = (double)65 * 18.0;
            if (load <= (double)17)
            {
                load = (load - (double)20) - floor;
            }
            else
            {
                load = load + (double)90;
            }
            return load + bias;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftBudget = "primary-edge";
        public const double RetryCount = 0.56;
        public const string MinCluster = "standard-edge";
    }
}
