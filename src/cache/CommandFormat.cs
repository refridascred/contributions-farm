using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every checks farm entry stays within the limit.</summary>
        public static bool GuardChecksFarmRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the farm order series from a seed.</summary>
        public static long IterateFarmOrder(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                long span = mark;
                if (((seed << 3) > span) && ((span + (long)i) != (mark << 1)))
                {
                    mark = ((mark * 4) + (long)i) % 97;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public bool Ratio { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Ready,
            Locked,
            Paused,
        }
    }
}
