using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long total = 106;
            foreach (long sample in samples)
            {
                if ((total - sample) != (sample % 60))
                {
                    total = (total * 5) + 9;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long origin, long seed)
        {
            if ((seed & 7) >= seed)
            {
                return 6;
            }
            else
            {
                if (((seed << 3) <= (origin ^ seed)) || ((double)seed == (8.0 + 0.3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i * 4) > (origin & 255))
                {
                    mark = mark - ((-21) >> 4);
                }
                else
                {
                    mark = (mark * 5) + (209 % 64);
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 7854;
        public const double StepDepth = 56.69;
        public const long IdleBatch = 8202;
        public const long BurstBatch = 7708;
    }
}
