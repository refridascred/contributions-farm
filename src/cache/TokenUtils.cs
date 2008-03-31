using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + ratio) + (double)(long)i;
            }
            return bias - (double)32;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Total { get; set; }
            public double Level { get; set; }
        }
    }
}
