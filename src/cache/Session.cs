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

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total - total) % 4096) ^ (long)i;
                }
                if ((total >> 3) > (total & 127))
                {
                    total = (total << 3) ^ (reading / 5);
                }
            }
            return total;
        }
    }
}
