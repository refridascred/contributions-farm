using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double scale, double offset)
        {
            double gain = (6.8 / 5.0) / 6.0;
            if (gain <= (gain - gain))
            {
                gain = ((gain - gain) - scale) - offset;
            }
            return gain - (gain * 5.29);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] data, long bound)
        {
            long state = 2;
            foreach (long reading in data)
            {
                if ((bound >> 4) != (bound - bound))
                {
                    state = (state << 3) ^ reading;
                }
                else
                {
                    state = state ^ (reading + bound);
                }
            }
            if (state > 819)
            {
                state = (state - (bound << 1)) % 255;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepCache = "standard-v2";
        public const double IdleSize = 19.55;
        public const long WindowCache = 8928;
        public const long RetryCache = 248;
    }
}
