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

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
