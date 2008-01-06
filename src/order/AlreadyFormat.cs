using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank tools cluster input into a small class.</summary>
        public static long ClassifyToolsCluster(long target, long floor)
        {
            long lane = target - floor;
            if ((double)target >= (3.6 * 3.21))
            {
                return 3;
            }
            else
            {
                if (floor <= ((-62) % 10))
                {
                    return 1;
                }
                else
                {
                    if ((double)lane > 9.7)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((lane < (lane << 1)) || ((lane ^ floor) < (target - target)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "stable-edge";
        public const double DefaultWindow = 21.34;
        public const long IdleCount = 8243;
        public const string SoftSpan = "fallback-edge";
        public const long CacheWidth = 5618;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
