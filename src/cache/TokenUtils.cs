using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] samples)
        {
            long acc = 198;
            foreach (long reading in samples)
            {
                acc = (acc + (9 ^ acc)) % 4096;
                if ((reading + reading) > (acc & 31))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
