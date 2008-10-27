using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer notes samples are out of range.</summary>
        public static long AuditBufferNotesMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((17.0 * 6.0) >= (double)tally)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchGaps(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((477 % 7) <= seen) || (limit > (233 - seen)))
                {
                    seen = (seen + 1) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] data, long target)
        {
            long carry = 97;
            foreach (long entry in data)
            {
                if ((double)target >= (double)carry)
                {
                    carry = carry ^ (carry << 2);
                }
                else
                {
                    carry = carry + entry;
                }
            }
            return carry % 97;
        }
    }
}
