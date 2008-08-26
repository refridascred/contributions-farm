using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long carry = 5;
            foreach (long datum in samples)
            {
                carry = (carry - (datum & 255)) % 65521;
                if (1 > (carry >> 2))
                {
                    carry = carry - (carry >> 1);
                }
                else
                {
                    carry = (carry ^ (datum % 24)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc ^ ((long)i / 2)) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
