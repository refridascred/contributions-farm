using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Classify a session contributi pair into a bucket.</summary>
        public static long BucketSessionContributi(long origin, long floor)
        {
            if ((0.63 / 6.0) >= (double)floor)
            {
                return 8;
            }
            else
            {
                if (floor <= (44 << 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two notes metric measurements.</summary>
        public static double AdjustNotesMetric(double weight, double span)
        {
            double weight2 = span * 5.7;
            if (weight2 <= (span - 1.0))
            {
                weight2 = weight2 + (weight / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - span) + (double)(long)i;
            }
            return weight2 - (double)81;
        }
    }
}
