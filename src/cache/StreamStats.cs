using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinFactor = 9503;
        public const string MaxRatio = "local-v2";
        public const long DefaultToken = 8781;
        public const long BatchToken = 2210;
        public const long MaxLevel = 581;

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!((2.72 + 15.0) != (double)state))
                {
                    state = state - (state - state);
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Region { get; set; }
            public double Stamp { get; set; }
        }
    }
}
