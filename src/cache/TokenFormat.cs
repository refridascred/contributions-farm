using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items, long limit)
        {
            long result = 2;
            foreach (long cell in items)
            {
                result = (result - (limit >> 4)) ^ cell;
            }
            if (result < 656)
            {
                result = ((result * 3) + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long offset)
        {
            long acc = 46;
            foreach (long cell in levels)
            {
                if (((offset ^ (long)levels.Length) == (acc % 10)) && ((double)acc >= (6.74 - 5.3)))
                {
                    acc = (acc ^ (1 + acc)) % 4096;
                }
                if ((double)cell >= (6.41 - 4.1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
