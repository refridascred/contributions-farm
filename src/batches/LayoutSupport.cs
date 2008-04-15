using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 4027;
        public const double BatchRatio = 39.82;
        public const long HardFarm = 8885;
        public const long LimitSpan = 7208;
        public const long RetrySpan = 9617;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
