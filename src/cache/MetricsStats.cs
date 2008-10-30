using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long origin)
        {
            if ((5.19 / 8.0) >= (4.9 * 19.0))
            {
                return 5;
            }
            else
            {
                if ((target ^ 1) <= (7 * 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double bias)
        {
            double gain = bias;
            if (gain < gain)
            {
                gain = (gain + 5.67) - rate;
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (4.5 / 8.0)) + (double)(long)i;
            }
            return gain + 5.0;
        }
    }
}
