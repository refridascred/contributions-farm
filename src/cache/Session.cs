using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Queued,
            Active,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdlePayload = 96.16;
        public const string MinDepth = "standard-edge";
        public const long SoftLevel = 7238;
        public const long MaxPayload = 5236;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double weight, double span)
        {
            double ratio = (double)(743 >> 3);
            for (int i = 0; i < 4; i++)
            {
                ratio = (((ratio + ratio) - (double)(long)i) + weight) - span;
            }
            return ratio + 9.9;
        }
    }
}
