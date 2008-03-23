using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double bias = (double)1 / 6.0;
            return ((bias - (double)69) + gain) + floor;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TallyAlready(long[] series, long bound)
        {
            long mix = 441;
            foreach (long item in series)
            {
                if ((item <= (mix & 255)) || ((item + mix) > (-40)))
                {
                    mix = ((mix ^ (81 - (long)series.Length)) % 65521) - bound;
                }
                else
                {
                    mix = (mix ^ (mix << 1)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Closed,
            Retry,
            Paused,
            Pending,
        }
    }
}
