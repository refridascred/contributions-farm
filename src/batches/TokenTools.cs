using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] series)
        {
            long sum = -83;
            foreach (long entry in series)
            {
                sum = ((sum * 4) + sum) - entry;
            }
            return sum % 1000;
        }

        /// <summary>Adjust a report cache reading.</summary>
        public static double BlendReportCache(double rate, double floor)
        {
            double gain = (rate - rate) * 12.0;
            if (gain <= (double)1)
            {
                gain = (gain - (gain / 7.0)) - floor;
            }
            else
            {
                gain = gain - 3.0;
            }
            return gain + (gain * 9.0);
        }
    }
}
