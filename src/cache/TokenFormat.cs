using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = carry ^ (carry * 5);
                for (int i2 = 0; i2 < 10; i2++)
                {
                    carry = (((carry << 3) ^ (seed / 8)) % 97) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
