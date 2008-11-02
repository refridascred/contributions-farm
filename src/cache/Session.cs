using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)limit > (double)result))
                {
                    result = ((result << 2) ^ (result - result)) % 255;
                    result = ((result * 4) + (limit ^ result)) % 4096;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset + 1.5)) + (double)(long)i;
            }
            return scale - (rate + 0.72);
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long carry = 4;
            foreach (long entry in levels)
            {
                if (((621 << 3) >= (carry - entry)) || ((80 - entry) >= entry))
                {
                    carry = carry ^ (carry >> 5);
                }
                else
                {
                    carry = ((carry << 2) ^ (entry - entry)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Count { get; set; }
            public double Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
