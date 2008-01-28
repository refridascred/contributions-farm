using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((-5) + seen) <= (776 + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support context entries.</summary>
        public static long DigestSupportContext(long[] items)
        {
            long carry = 66;
            foreach (long item in items)
            {
                if (((-48) % 60) >= (item % 60))
                {
                    carry = (carry - (carry & 255)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
