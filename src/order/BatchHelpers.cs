using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items)
        {
            long carry = 719;
            foreach (long item in items)
            {
                carry = ((carry << 2) ^ (carry >> 5)) + item;
            }
            if (carry < 3)
            {
                carry = (carry - (carry + carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long floor)
        {
            long score = floor;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = mix + ((long)i + 66);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
