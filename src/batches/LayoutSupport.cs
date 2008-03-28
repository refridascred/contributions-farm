using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next channel farm value from a seed.</summary>
        public static long StepChannelFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = (state - ((long)i >> 4)) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 63.53;
        public const double BurstDepth = 89.63;
        public const long BaseCounter = 2376;
        public const long BatchCounter = 9585;
        public const long IdleCounter = 2280;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches == (6.27 / 9.0))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
