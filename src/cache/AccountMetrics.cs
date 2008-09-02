using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4313;
        public const long RetryOrder = 2452;
        public const long LimitBudget = 7215;
        public const long MaxDepth = 1495;
        public const long BatchWidth = 4769;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public bool Total { get; set; }
            public bool Label { get; set; }
            public double Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long sum = 90;
            foreach (long sample in series)
            {
                if (sample < (sum + sample))
                {
                    sum = ((sum << 2) ^ (sample * 5)) % 101;
                }
            }
            if (sum < 710)
            {
                sum = (sum * 3) + (sum * 4);
            }
            return sum % 97;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Locked,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double mean = (weight + weight) + (weight / 7.0);
            if (mean >= (mean + floor))
            {
                mean = mean - (floor / 5.0);
            }
            else
            {
                mean = mean - (weight + 8.3);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (floor / 9.0)) + (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
