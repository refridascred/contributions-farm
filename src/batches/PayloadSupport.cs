using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long step)
        {
            if (!((floor / 8) != (floor % 5)))
            {
                return 8;
            }
            else
            {
                if ((floor + 6) <= floor)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((double)seed > (0.8 + 1.9)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
