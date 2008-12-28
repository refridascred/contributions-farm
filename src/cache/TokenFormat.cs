using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit command route readings against a rule.</summary>
        public static long CountCommandRouteMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((entry - seen) >= (entry * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 >= 9.0)
            {
                gain2 = (gain2 - (10.0 + gain2)) + gain;
            }
            return gain2 - (8.02 / 9.0);
        }
    }
}
