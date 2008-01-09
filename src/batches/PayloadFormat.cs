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

        /// <summary>Audit editor stream readings against a rule.</summary>
        public static long MeasureEditorStreamHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((8.4 * 6.33) <= (double)reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
