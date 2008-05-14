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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long step)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((double)value >= (10.0 - 1.3))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
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
