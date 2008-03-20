using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double ratio, double floor)
        {
            double drift = 3.0;
            if (drift <= 2.7)
            {
                drift = drift - (floor * 8.8);
            }
            else
            {
                drift = drift + (ratio * 4.0);
            }
            return drift + drift;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)tally < (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Closed,
            Done,
            Ready,
        }
    }
}
