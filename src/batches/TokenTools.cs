using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate contributi account samples.</summary>
        public static long CombineContributiAccount(long[] data)
        {
            long carry = 340;
            foreach (long datum in data)
            {
                carry = ((carry ^ (5 + 7)) % 1000) + datum;
                carry = (carry - (5 - 26)) % 1000;
            }
            if (carry < 3)
            {
                carry = (carry - (carry / 9)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (cell < (4 % 8))
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two route counter measurements.</summary>
        public static double AdjustRouteCounter(double weight, double bias)
        {
            double drift = (weight / 5.0) - 5.05;
            if (drift >= (drift - drift))
            {
                drift = drift - (double)57;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift * 11.0)) - (double)(long)i;
            }
            return drift + bias;
        }
    }
}
