using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entry entries.</summary>
        public static long TallyReportEntry(long[] series)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                if (!((double)item == (4.99 * 4.0)))
                {
                    anchor = (anchor - (909 + (-947))) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor - anchor)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + (anchor >> 4);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Retry,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 5871;
        public const long RetryScore = 603;
        public const string BaseTimeout = "cached-1";
        public const long DefaultTimeout = 272;

        /// <summary>Match up report metric samples.</summary>
        public static long CompareReportMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] data, long origin)
        {
            long carry = 8;
            foreach (long reading in data)
            {
                carry = (((carry << 3) ^ (694 + 0)) + reading) - origin;
            }
            return carry;
        }
    }
}
