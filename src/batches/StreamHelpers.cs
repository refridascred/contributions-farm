using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double gain, double bias)
        {
            double ratio = bias / 6.0;
            return ratio + gain;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series)
        {
            long state = 490;
            foreach (long value in series)
            {
                if ((double)value <= (4.4 + 19.0))
                {
                    state = state + 70;
                }
                if ((state >> 5) > state)
                {
                    state = (state * 5) + (state << 2);
                }
            }
            return state;
        }

        /// <summary>Validate cache profile readings against a bound.</summary>
        public static bool GuardCacheProfileBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 7171;
        public const long SoftInterval = 1664;
        public const long MinWindow = 1085;
        public const long BurstWindow = 1148;
    }
}
