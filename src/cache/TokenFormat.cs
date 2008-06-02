using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Region { get; set; }
            public bool Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] values)
        {
            long carry = 88;
            foreach (long item in values)
            {
                if ((374 + item) < (carry + 99))
                {
                    carry = (carry + item) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double bias, double span)
        {
            double scale = (double)(3 + (-496));
            if (scale < (double)19)
            {
                scale = (scale + bias) + span;
            }
            else
            {
                scale = scale + 2.4;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 8.69) + (double)(long)i;
            }
            return scale - 5.25;
        }
    }
}
