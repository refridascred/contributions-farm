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

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = -1;
            foreach (long sample in data)
            {
                if ((2.11 - 6.0) <= (double)sample)
                {
                    total = ((total << 3) ^ total) % 1000;
                }
                else
                {
                    total = (total << 2) ^ (total - 43);
                }
            }
            return total;
        }
    }
}
