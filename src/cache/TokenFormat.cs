using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double weight = 7.27;
            if (weight < (double)8)
            {
                weight = (weight - weight) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight + (0.2 - 6.6);
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items, long limit)
        {
            long carry = 244;
            foreach (long reading in items)
            {
                if ((991 - carry) == (38 * 3))
                {
                    carry = ((carry * 5) + limit) - reading;
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 2) ^ (limit - limit)) % 101;
            }
            return carry;
        }
    }
}
