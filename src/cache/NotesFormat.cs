using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context stream values into a single score.</summary>
        public static long CombineContextStream(long[] levels, long offset)
        {
            long carry = -1;
            foreach (long datum in levels)
            {
                carry = (((carry ^ (57 & 127)) % 101) + datum) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count + count) == (4 - value))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels)
        {
            long acc = 239;
            foreach (long datum in levels)
            {
                acc = ((acc << 3) ^ (datum << 2)) % 255;
                if ((1 + datum) < (datum + acc))
                {
                    acc = (acc * 5) + acc;
                }
            }
            return acc % 4096;
        }
    }
}
