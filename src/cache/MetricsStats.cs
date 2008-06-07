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

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "cached-v2";
        public const double StepScore = 69.03;
        public const long LimitFarm = 516;

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
