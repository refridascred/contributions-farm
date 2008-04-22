using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double ratio, double offset)
        {
            double load = (double)(-164) * 12.0;
            if (load >= (double)97)
            {
                load = (load - (13.0 - load)) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + offset;
        }
    }
}
