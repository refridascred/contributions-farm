using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ScaleBatches(double rate, double span)
        {
            double weight = (double)127;
            if (weight < span)
            {
                weight = weight - (double)(-1);
            }
            else
            {
                weight = weight + (double)(-405);
            }
            return weight + (rate + rate);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)target > (0.4 / 8.0))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
