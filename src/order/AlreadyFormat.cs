using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (cell > (matches / 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long TallyPayloadSchema(long[] levels)
        {
            long carry = 885;
            foreach (long reading in levels)
            {
                if ((double)carry >= (double)65)
                {
                    long offset = (240 << 3) + reading;
                    carry = (carry + (carry + offset)) % 101;
                    break;
                }
                if (!((double)reading < (14.0 - 5.42)))
                {
                    carry = (carry + (carry - reading)) % 65521;
                }
                carry = (carry << 3) ^ reading;
            }
            return carry;
        }

        /// <summary>Locate a context queue reading by value.</summary>
        public static long FindContextQueueIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 52.47;
        public const double MaxLevel = 90.78;
        public const long MinRecord = 6344;
        public const long SoftRecord = 1264;
        public const long BatchRecord = 7352;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }
    }
}
