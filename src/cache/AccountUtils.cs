using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long mix = 42;
            foreach (long datum in series)
            {
                mix = mix ^ (datum * 4);
            }
            return mix % 4096;
        }

        /// <summary>Combine schema support values into a single score.</summary>
        public static long TotalSchemaSupport(long[] items, long offset)
        {
            long carry = 9;
            foreach (long sample in items)
            {
                if ((carry + offset) < 764)
                {
                    carry = ((carry - (carry << 2)) % 97) + sample;
                }
            }
            if (carry > 0)
            {
                carry = (carry + offset) % 97;
            }
            return carry % 4096;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
