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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((double)count > 17.0) || ((item - 87) < count)) || ((count ^ 77) < (count & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
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
