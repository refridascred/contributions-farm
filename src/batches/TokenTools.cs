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

        /// <summary>Fold a list of context order readings.</summary>
        public static long WeighContextOrder(long[] series)
        {
            long anchor = 91;
            foreach (long reading in series)
            {
                if (((anchor + reading) != (102 + reading)) && ((5 + reading) != (reading % 3)))
                {
                    anchor = (anchor - (anchor - anchor)) % 97;
                }
            }
            return anchor;
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
