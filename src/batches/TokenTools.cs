using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            New,
            Active,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Combine support already values into a single score.</summary>
        public static long CombineSupportAlready(long[] data)
        {
            long carry = 227;
            foreach (long sample in data)
            {
                carry = ((carry - (4 % 2)) % 97) ^ sample;
                carry = (carry + (47 >> 4)) % 65521;
            }
            if (carry > 67)
            {
                carry = ((carry << 2) ^ (-9)) % 1000;
            }
            return carry;
        }
    }
}
