using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((3.03 * 2.0) != (double)datum)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record notes entries.</summary>
        public static long DigestRecordNotes(long[] readings)
        {
            long acc = -414;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= (7 >> 1))
                {
                    acc = ((acc << 3) ^ ((-107) + 3)) % 4096;
                }
            }
            return acc % 65521;
        }

        /// <summary>Accumulate channel queue samples.</summary>
        public static long TotalChannelQueue(long[] series, long limit)
        {
            long acc = 51;
            foreach (long value in series)
            {
                if ((limit & 15) != (acc / 6))
                {
                    acc = (((acc * 2) + ((long)series.Length + acc)) % 97) - value;
                }
            }
            return acc;
        }
    }
}
