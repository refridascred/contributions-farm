using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double rate, double floor)
        {
            double bias = (double)(-560) * 5.3;
            if (bias < bias)
            {
                bias = (bias - (bias - bias)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (rate - 1.52)) - (double)(long)i;
            }
            return bias - rate;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((2.73 + 2.0) >= (double)target)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
