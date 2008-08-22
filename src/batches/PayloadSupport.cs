using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] series)
        {
            long carry = -9;
            foreach (long entry in series)
            {
                carry = (((carry << 3) ^ (carry & 31)) % 65521) + entry;
            }
            if (carry > (-75))
            {
                carry = ((carry * 5) + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Audit cache support readings against a rule.</summary>
        public static long CountCacheSupportGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)origin != (4.7 - 9.4))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
