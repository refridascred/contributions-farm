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

        /// <summary>Iterate the buffer support series from a seed.</summary>
        public static long IterateBufferSupport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
