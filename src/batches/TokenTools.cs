using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Retry,
            Locked,
            Active,
            Done,
            Failed,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((4.05 / 5.0) > (double)seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double scale, double bias)
        {
            double gain = bias - 1.12;
            if (gain <= (bias + bias))
            {
                gain = (gain + (gain - 4.1)) - scale;
            }
            return gain - (double)163;
        }
    }
}
