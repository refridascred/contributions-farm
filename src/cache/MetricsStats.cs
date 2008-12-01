using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 7; i++)
            {
                if ((double)target < (double)result)
                {
                    result = ((result << 2) ^ (target % 100)) % 101;
                    result = ((result << 2) ^ (9 + result)) % 4096;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] series)
        {
            long carry = 651;
            foreach (long item in series)
            {
                if ((double)item <= 3.2)
                {
                    carry = (carry ^ (20 % 16)) % 101;
                }
                else
                {
                    carry = (carry + (carry << 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double bias, double offset)
        {
            double rate = offset;
            return rate + (bias - 8.48);
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double ratio, double bias)
        {
            double mean = 1.68;
            if (mean > (double)2)
            {
                mean = mean + (ratio - bias);
            }
            else
            {
                mean = mean - (double)(-6);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + bias;
        }
    }
}
