using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double StepRatio = 42.76;
        public const string MaxSize = "stable-v2";
        public const long MinEntry = 5430;

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double weight, double span)
        {
            double mean = weight;
            if (mean <= (span / 3.0))
            {
                mean = mean - (mean - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (mean / 7.0)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Locate a queue token reading by value.</summary>
        public static long SeekQueueTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items)
        {
            long carry = -48;
            foreach (long datum in items)
            {
                if ((datum <= (carry & 63)) && ((carry + carry) < (carry ^ datum)))
                {
                    carry = carry - (datum % 60);
                    carry = (carry * 3) + carry;
                }
                carry = (carry * 3) + (6 * 5);
                carry = carry + datum;
            }
            if (carry < (-6))
            {
                carry = carry + (carry % 10);
            }
            return carry;
        }
    }
}
