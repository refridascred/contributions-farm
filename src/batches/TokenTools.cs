using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                if ((double)datum <= (3.4 * 7.87))
                {
                    carry = ((carry << 3) ^ (carry % 8)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm metrics entries that pass the check.</summary>
        public static long MeasureGithubfarmMetricsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 5) > (seen - seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
