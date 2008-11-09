using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate stats layout samples.</summary>
        public static long CombineStatsLayout(long[] samples, long step)
        {
            long mark = -51;
            foreach (long datum in samples)
            {
                if (step <= (step * 4))
                {
                    mark = mark - (datum >> 3);
                }
            }
            if (mark > 819)
            {
                mark = (mark + (mark - (long)samples.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long seed)
        {
            long next = floor - seed;
            if (!((8.0 - 9.05) < (double)floor))
            {
                return 0;
            }
            else
            {
                if ((next - floor) != (floor << 1))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
