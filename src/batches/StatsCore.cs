using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + weight) + (double)(long)i) - bias2;
            }
            return weight + (bias / 4.0);
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Retry,
            Done,
            Queued,
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(((long)i & 31) >= (carry & 7)))
                {
                    carry = carry + (carry + limit);
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Done,
            Closed,
            New,
        }
    }
}
