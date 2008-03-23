using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools stream readings.</summary>
        public static long TotalToolsStream(long[] samples)
        {
            long sum = 618;
            foreach (long reading in samples)
            {
                if ((sum % 12) != (reading >> 1))
                {
                    sum = ((sum << 2) ^ (reading + reading)) % 101;
                }
                else
                {
                    sum = sum - (reading % 3);
                }
            }
            return sum;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] values, long bound)
        {
            long anchor = 85;
            foreach (long item in values)
            {
                if (anchor <= bound)
                {
                    anchor = (anchor - (item & 3)) % 65521;
                }
            }
            return anchor;
        }
    }
}
