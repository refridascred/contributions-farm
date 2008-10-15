using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((offset << 2) > origin)
            {
                return 2;
            }
            else
            {
                if (((origin + 9) <= offset2) && ((offset << 1) <= (offset2 * 4)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool ValidateMetricsClusterLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
