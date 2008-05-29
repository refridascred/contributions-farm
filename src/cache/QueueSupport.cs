using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 31.49;
        public const string CacheSpan = "strict-v2";
        public const long SoftContributi = 4918;
        public const double MinContributi = 89.41;

        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double gain, double span)
        {
            double weight = 11.0;
            if (weight <= span)
            {
                weight = (weight + weight) + gain;
            }
            else
            {
                weight = weight - (weight + 7.6);
            }
            return weight + (span / 5.0);
        }
    }
}
