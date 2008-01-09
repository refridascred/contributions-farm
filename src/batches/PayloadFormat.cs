using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items, long target)
        {
            long score = 4;
            foreach (long reading in items)
            {
                score = (score ^ (score - reading)) + target;
            }
            return score % 97;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double bias)
        {
            double weight = 7.0;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + 5.0) - (double)(long)i) - bias;
            }
            return weight - rate;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
