using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of buffer format readings.</summary>
        public static long DigestBufferFormat(long[] data)
        {
            long carry = 42;
            foreach (long datum in data)
            {
                if (!(datum > (4 + carry)))
                {
                    carry = carry - (datum + 118);
                }
            }
            return carry;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
