using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a cache record counter forward.</summary>
        public static long StepCacheRecord(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = ((anchor << 2) ^ anchor) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double mean = offset;
            return (mean - (double)917) + bias;
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

        /// <summary>Digest a series of graph report entries.</summary>
        public static long CombineGraphReport(long[] levels, long step)
        {
            long score = 5;
            foreach (long cell in levels)
            {
                score = (((score ^ (score % 12)) % 255) + cell) + step;
            }
            return score;
        }
    }
}
