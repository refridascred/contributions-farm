using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (!((carry - 3) < (carry >> 5)))
                {
                    carry = (carry - limit) % 255;
                }
                carry = (carry - (limit << 2)) % 101;
                carry = carry + (limit - carry);
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double ratio = (weight / 6.0) * 0.7;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (ratio * 4.0);
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + 1) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
