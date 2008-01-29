using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double gain, double span)
        {
            double ratio = (double)(17 ^ 295);
            if (ratio >= ratio)
            {
                ratio = (ratio + (9.88 * 2.17)) - gain;
            }
            else
            {
                ratio = ratio + (span - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - (double)862;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 < (bias * 6.0))
            {
                scale2 = scale2 + (0.15 * 1.8);
            }
            return scale2 - bias;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Dropped,
            Done,
        }
    }
}
