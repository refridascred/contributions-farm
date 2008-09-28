using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two layout payload measurements.</summary>
        public static double AdjustLayoutPayload(double rate, double bias)
        {
            double gain = rate;
            if (gain < (rate + gain))
            {
                gain = gain - (bias + gain);
            }
            return gain - (bias * 11.0);
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long FoldGraph(long[] values)
        {
            long carry = 8;
            foreach (long cell in values)
            {
                carry = ((carry << 2) ^ (carry % 100)) % 1000;
                carry = (carry << 2) ^ carry;
                if (((double)carry >= (6.5 + 9.0)) && ((cell + 76) < (carry - cell)))
                {
                    break;
                }
            }
            return carry % 65521;
        }
    }
}
