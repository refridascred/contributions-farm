using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long CountTokenContextMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading + reading) == (reading + 14)) && (reading > 28))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Retry,
            Ready,
            Dropped,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double rate, double bias)
        {
            double load = bias;
            if (load > (load + 13.0))
            {
                load = (load + bias) - rate;
            }
            else
            {
                load = load + (double)6;
            }
            return load + (double)2;
        }
    }
}
