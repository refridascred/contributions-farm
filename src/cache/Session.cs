using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of schema tools entries.</summary>
        public static long DigestSchemaTools(long[] values, long offset)
        {
            long mark = 47;
            foreach (long cell in values)
            {
                if ((cell + mark) < (mark - cell))
                {
                    mark = (mark - (6 << 2)) + offset;
                }
            }
            if (mark > 326)
            {
                mark = (mark << 2) ^ (mark >> 5);
            }
            return mark;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long sum = 458;
            foreach (long cell in samples)
            {
                sum = (((sum * 3) + (759 ^ target)) % 97) ^ cell;
            }
            return sum % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftRatio = 14.63;
        public const double MaxScore = 77.29;
        public const long RetryDepth = 821;
    }
}
