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

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
