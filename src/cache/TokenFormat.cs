using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = acc ^ (acc * 3);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc - 496) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((9.3 - 6.7) > (double)entry)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }
    }
}
