using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "open-v2";
        public const long SoftRatio = 4619;
        public const long StepFactor = 1436;
        public const string IdleQueue = "latest-v2";
        public const long BaseLevel = 8520;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 3738;
        public const long LimitFarm = 635;
        public const long CacheFarm = 91;
        public const long BurstFarm = 6780;

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Owner { get; set; }
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + (sum << 1)) % 101;
                long span = (65 + 947) + (349 % 10);
                if ((75 << 1) != ((long)i >> 4))
                {
                    long next = span;
                    sum = ((sum * 4) + (next - (long)i)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
