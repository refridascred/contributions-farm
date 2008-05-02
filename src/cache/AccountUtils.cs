using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = carry ^ ((long)i2 << 3);
                    carry = (carry ^ (long)i2) % 65521;
                }
                carry = ((carry << 2) ^ (step + (long)i)) % 255;
                carry = carry - carry;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
