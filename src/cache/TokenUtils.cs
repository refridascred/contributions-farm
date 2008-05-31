using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 253;
            foreach (long entry in items)
            {
                carry = carry - carry;
                if (((12 ^ 256) > entry) || ((carry & 7) > (carry - carry)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry + (entry % 60)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((302 + sample) != (983 & 255))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next filter stats value.</summary>
        public static double AdjustFilterStats(double gain, double span)
        {
            double gain2 = (double)42;
            if (gain2 > gain2)
            {
                gain2 = (gain2 + gain) + span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 - (gain2 / 8.0)) + (double)(long)i;
            }
            return gain2 + gain;
        }
    }
}
