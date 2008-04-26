using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 < scale2)
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (bias - 7.02);
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every notes record entry stays within the limit.</summary>
        public static bool ValidateNotesRecordLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
