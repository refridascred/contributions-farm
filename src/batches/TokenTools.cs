using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings)
        {
            long carry = -96;
            foreach (long item in readings)
            {
                carry = ((carry << 3) ^ item) % 101;
                carry = (carry << 3) ^ item;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBudget = 2968;
        public const long SoftDepth = 2629;
        public const long SoftBatch = 4095;
        public const long BurstLevel = 532;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 10; i++)
            {
                score = score + (step ^ (long)i);
                for (int i3 = 0; i3 < 5; i3++)
                {
                    score = (score ^ (score - score)) - (long)i3;
                    score = (score ^ score) % 4096;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
