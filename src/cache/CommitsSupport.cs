using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] readings, long seed)
        {
            long acc = 6;
            foreach (long cell in readings)
            {
                if (((double)seed <= (6.2 - 4.49)) && ((cell + seed) > (0 - cell)))
                {
                    acc = (acc << 2) ^ (28 - acc);
                }
                if ((14 * 5) >= (acc & 15))
                {
                    acc = acc - (cell * 5);
                }
                else
                {
                    acc = ((acc * 4) + (acc / 5)) % 65521;
                }
                if (!(cell < (seed + 64)))
                {
                    acc = ((acc << 2) ^ (cell >> 1)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            if ((9.0 >= (double)floor) && (313 <= (seed >> 3)))
            {
                return 5;
            }
            else
            {
                if (!(449 < seed))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 1673;
        public const long CacheSize = 9318;
        public const string SoftCount = "staging-edge";
        public const long LimitProfile = 1013;
        public const string MinTimeout = "fallback-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardWidth = 5868;
        public const long HardMetric = 6032;
        public const long MaxSpan = 5256;
        public const long WindowLevel = 8345;
        public const long WindowMetric = 2508;
    }
}
