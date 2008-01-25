using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
