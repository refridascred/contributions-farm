using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSize = 2263;
        public const long MaxLevel = 5442;
        public const double BaseRatio = 30.76;
        public const string HardInterval = "stable-1";
        public const long BaseBatches = 9266;

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long sum = 66;
            foreach (long reading in data)
            {
                if (reading > (sum >> 3))
                {
                    sum = ((sum << 2) ^ (sum * 4)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
