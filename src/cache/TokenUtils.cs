using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                if ((4.12 + 7.0) >= (double)carry)
                {
                    carry = (carry * 4) + ((long)i << 1);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Blend two commits notes measurements.</summary>
        public static double SmoothCommitsNotes(double weight, double span)
        {
            double load = (double)(389 + 205);
            if (load >= (weight + span))
            {
                load = load - span;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + weight) - (double)(long)i;
            }
            return load + (weight + weight);
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double bias, double floor)
        {
            double load = floor;
            if (load >= (bias - floor))
            {
                load = load + load;
            }
            return load + (7.2 + 9.62);
        }
    }
}
