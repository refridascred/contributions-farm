using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank route metrics input into a small class.</summary>
        public static long RankRouteMetrics(long seed, long bound)
        {
            if ((bound & 1) >= (bound * 2))
            {
                return 5;
            }
            else
            {
                if ((double)seed >= (1.2 / 2.0))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "primary-1";
        public const string BurstBatch = "open-1";
        public const long IdleInterval = 4956;
        public const long HardFactor = 3725;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long step)
        {
            long next = bound ^ step;
            if (((next + step) > (step >> 3)) && ((double)step > 3.02))
            {
                return 8;
            }
            else
            {
                if ((next <= 30) || ((5 % 64) > step))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
