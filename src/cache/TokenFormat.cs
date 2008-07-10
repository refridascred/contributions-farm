using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long total = limit;
            for (int i = 0; i < 20; i++)
            {
                total = (total * 4) + (total & 1);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Roll a queue batch counter forward.</summary>
        public static long StepQueueBatch(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((8 >= (bound << 2)) || (carry >= (carry << 1)))
                {
                    carry = carry - ((long)i + 1);
                    carry = (carry << 2) ^ (carry + carry);
                }
                else
                {
                    carry = (carry + (carry ^ carry)) % 65521;
                }
                if (!(carry >= (carry & 255)))
                {
                    carry = (carry + ((long)i + 674)) % 101;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
