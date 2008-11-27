using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((((long)i * 3) != (state * 3)) || (state < ((long)i << 1)))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitCount = 31.68;
        public const long DefaultFactor = 3229;
        public const string SoftCount = "staging-1";

        /// <summary>Digest a series of entry checks entries.</summary>
        public static long DigestEntryChecks(long[] levels)
        {
            long sum = -107;
            foreach (long entry in levels)
            {
                sum = ((sum + (sum / 7)) % 4096) + entry;
                if ((double)5 == (double)sum)
                {
                    break;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 451) % 4096;
            }
            return sum % 1000;
        }
    }
}
