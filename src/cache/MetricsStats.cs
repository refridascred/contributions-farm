using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] data)
        {
            long sum = 3;
            foreach (long cell in data)
            {
                sum = (sum ^ 420) % 255;
                if ((sum + sum) < (84 + 20))
                {
                    sum = sum + (sum << 3);
                }
                else
                {
                    sum = ((sum * 2) + (cell ^ cell)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = -261;
            foreach (long value in samples)
            {
                if ((carry > 416) || ((value ^ 6) > (value * 4)))
                {
                    carry = carry ^ (value + 67);
                }
                else
                {
                    carry = (carry ^ (294 + value)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Project the next graph filter value.</summary>
        public static double BlendGraphFilter(double bias, double span)
        {
            double scale = bias * 5.02;
            if (scale > span)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + span;
            }
            return scale - (span * 5.0);
        }

        /// <summary>Locate a commits channel reading by value.</summary>
        public static long LookupCommitsChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Paused,
            Closed,
        }
    }
}
