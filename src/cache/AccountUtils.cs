using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] levels)
        {
            long result = 84;
            foreach (long cell in levels)
            {
                result = ((result << 3) ^ (result & 127)) + cell;
            }
            return result;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((double)cell > 4.42)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }
    }
}
