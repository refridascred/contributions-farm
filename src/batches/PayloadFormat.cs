using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long target)
        {
            long score = target;
            for (int i = 0; i < 17; i++)
            {
                score = score + (score / 6);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinRatio = 9519;
        public const long BatchWindow = 3984;
        public const double CacheFactor = 10.61;
        public const double MaxWindow = 70.71;
    }
}
