using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two window context measurements.</summary>
        public static double ScaleWindowContext(double weight, double bias)
        {
            double rate = weight * 0.7;
            if (rate > weight)
            {
                rate = (rate - (double)(-9)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate * 7.3)) + (double)(long)i;
            }
            return rate + (rate / 9.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 6392;
        public const double WindowCommits = 27.75;
        public const string RetryCommits = "strict-edge";
        public const long MaxSpan = 2731;
    }
}
