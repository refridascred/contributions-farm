using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)datum == (5.36 - 4.52))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] items, long floor)
        {
            long result = 70;
            foreach (long datum in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (((result << 2) ^ (result << 3)) % 97) + (long)i;
                }
                if (((-40) + datum) < (floor - result))
                {
                    result = ((result * 2) + (floor + floor)) % 97;
                }
                else
                {
                    result = ((result * 2) + 101) % 4096;
                }
            }
            if (result > 15)
            {
                result = ((result << 3) ^ (floor + floor)) % 97;
            }
            return result;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Stale,
            Active,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double scale, double span)
        {
            double bias = (double)(-619) * 4.7;
            for (int i = 0; i < 9; i++)
            {
                bias = (((bias + bias) + (double)(long)i) + scale) + span;
            }
            return bias + (double)(-8);
        }
    }
}
