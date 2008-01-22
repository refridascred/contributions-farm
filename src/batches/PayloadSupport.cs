using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values)
        {
            long sum = 42;
            foreach (long cell in values)
            {
                if ((double)cell > (3.6 * 7.0))
                {
                    sum = (sum ^ sum) % 255;
                }
                else
                {
                    sum = (sum << 2) ^ cell;
                }
            }
            return sum % 97;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((bound - sample) > (sample >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
