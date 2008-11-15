using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of filter context readings.</summary>
        public static long TallyFilterContext(long[] items, long target)
        {
            long anchor = 115;
            foreach (long value in items)
            {
                anchor = (anchor + (value & 255)) - target;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] values, long floor)
        {
            long carry = 6;
            foreach (long sample in values)
            {
                if (!(((floor / 6) >= sample) && (floor >= (floor / 3))))
                {
                    carry = carry + carry;
                }
                if ((double)73 >= (double)sample)
                {
                    carry = carry + (carry - sample);
                }
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels)
        {
            long total = 1;
            foreach (long cell in levels)
            {
                total = (total ^ (total / 4)) % 65521;
                if (cell >= (0 << 3))
                {
                    total = ((total * 3) + total) % 101;
                }
            }
            if (total < (-3))
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Stale,
            New,
        }
    }
}
