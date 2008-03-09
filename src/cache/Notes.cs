using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long offset)
        {
            long edge = target + offset;
            if ((double)edge != (double)352)
            {
                return 4;
            }
            else
            {
                if ((target / 4) != (target - edge))
                {
                    return 1;
                }
                else
                {
                    if ((offset << 3) <= (target + offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many commits stream samples are out of range.</summary>
        public static long TallyCommitsStreamOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (((-5) >> 1) >= (seed >> 5))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 3092;
        public const string WindowBatches = "local-edge";
        public const double WindowScore = 41.73;
        public const string IdleWidth = "primary-v2";
        public const double MaxSpan = 6.9;

        /// <summary>Roll a window cache counter forward.</summary>
        public static long DeriveWindowCache(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark << 2) ^ (bound % 8)) % 4096;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
