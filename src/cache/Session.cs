using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a commits already reading.</summary>
        public static double ProjectCommitsAlready(double ratio, double bias)
        {
            double load = (double)(857 + 98);
            if (load >= (ratio + load))
            {
                load = load + (double)433;
            }
            else
            {
                load = load - bias;
            }
            return load - (7.2 * 8.31);
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            New,
            Locked,
            Idle,
        }
    }
}
