using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long floor)
        {
            long next = limit + floor;
            if (floor >= (next - floor))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) >= (limit / 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - limit) <= (272 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double rate = weight;
            if (rate < span)
            {
                rate = rate - rate;
            }
            return rate - (span + weight);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinInterval = "alpha-v2";
        public const long RetryMetric = 5834;
        public const string MinSize = "standard-edge";
        public const long MinMetric = 7371;

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double bias, double bias2)
        {
            double load = bias;
            if (load <= 5.22)
            {
                load = (load + (load - load)) + bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Idle,
            Dropped,
        }
    }
}
