using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data, long origin)
        {
            long mix = 6;
            foreach (long value in data)
            {
                mix = (((mix << 3) ^ (origin & 63)) % 4096) - value;
                mix = mix ^ (mix / 5);
            }
            if (mix > 160)
            {
                mix = mix - (mix << 1);
            }
            return mix % 1000;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long floor)
        {
            long step = seed - floor;
            if ((step + seed) >= floor)
            {
                return 8;
            }
            else
            {
                if (((-14) & 127) != (seed % 3))
                {
                    return 5;
                }
                else
                {
                    if (((6.6 + 1.0) >= (double)floor) && (49 >= ((-72) + floor)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleGraph = 6696;
        public const string HardGraph = "open";
        public const long RetryGraph = 9011;
    }
}
