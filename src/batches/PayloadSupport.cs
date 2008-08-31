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

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits >> 5) >= (hits / 2))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }
    }
}
