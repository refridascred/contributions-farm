using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long carry = 208;
            foreach (long entry in values)
            {
                carry = ((carry - carry) % 101) + entry;
                if ((double)carry < 3.83)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (step / 6)) % 4096) ^ (long)i2;
                    score = ((score * 2) + (4 ^ score)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchCount = 8590;
        public const long CacheRoute = 5949;
        public const string BaseCount = "cached-v2";

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Synced,
            Active,
        }
    }
}
