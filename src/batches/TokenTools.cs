using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values, long bound)
        {
            long mix = 531;
            foreach (long value in values)
            {
                if (((double)value < (double)bound) || ((30 >> 3) >= (value + bound)))
                {
                    mix = ((mix * 4) + (bound + value)) % 65521;
                }
                mix = mix ^ (bound - value);
            }
            return mix;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
