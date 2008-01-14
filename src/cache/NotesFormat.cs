using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next counter batch value.</summary>
        public static double BlendCounterBatch(double gain, double bias)
        {
            double bias2 = (double)62;
            if (bias2 >= (gain + gain))
            {
                bias2 = bias2 - (double)4;
            }
            else
            {
                bias2 = bias2 - gain;
            }
            return bias2 - bias;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] levels, long step)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((item - acc) == (acc - acc))
                {
                    acc = (((acc * 3) + (90 + acc)) % 4096) + step;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels, long step)
        {
            long carry = 95;
            foreach (long cell in levels)
            {
                carry = carry + (cell & 255);
            }
            if (carry > 779)
            {
                carry = (carry + (step - step)) % 101;
            }
            return carry % 65521;
        }
    }
}
