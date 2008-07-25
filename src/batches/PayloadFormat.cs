using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Total { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Dropped,
            New,
            Closed,
            Ready,
            Done,
        }
    }
}
